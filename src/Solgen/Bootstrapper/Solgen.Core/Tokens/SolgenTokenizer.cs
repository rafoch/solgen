using Solgen.Modules.CSharp.Tokens;
using Solgen.Shared.Abstractions.Tokens;

namespace Solgen.Core.Tokens;

public class SolgenTokenizer
{
    private readonly List<BaseTokenizer> _tokenizers = new()
    {
        new CSharpTokenizer(),
    };

    public IEnumerable<TokenResult> GetTokens(string uml)
    {
        // Replacing all unnecessary characters from string
        var umlWords = uml
            .Replace(System.Environment.NewLine, String.Empty).Split(' ')
            .Where(x => x != String.Empty);
        
        // setting depth level based on language open and closing brackets
        var depth = 1;
        var tokenIndex = 0;
        var tokens = new List<TokenResult>();
        
        //TODO change to regex
        foreach (var word in umlWords)
        {
            foreach (var tokenizer in _tokenizers)
            {
                var result = tokenizer.GetTokens(word, ref depth, ref tokenIndex);

                //When tokenizer doesnt return anything it means the word is unknow, should be resolved as error.
                if (result.Any(x => x.Token == null))
                {
                    continue;
                }
                
                tokens.AddRange(result);
                
                // there always is only ONE result from language tokenizer. When there are more than one then the code should break
                if (result.Count() > 1)
                {
                    throw new Exception("Tokenizer occured an error, there are more than one token based on provided input: {Error}");
                }
                
                var tokenResult = result.First();
                if (tokenResult.Token is { HasIdentifier: true })
                {
                    var identifier = umlWords.Select((x, index) => new {Value = x, Index = index}).Where(x => x.Index == tokenIndex).First();
                    tokenIndex++;
                    var tokenResult1 = new TokenResult(new IdentifierToken(identifier.Value), depth, tokenIndex);
                    tokens.Add(tokenResult1);
                }
            }
        }

        return tokens.Where(x => x.Token != null);
    }

    //TODO that's doesnt do anthing right now. It probably need a rewrite
    public IList<Token> GetAllAvailableTokens()
    {
        var tokens = _tokenizers.SelectMany(x => x.GetAvailableTokens()).ToList();

        return tokens;
    }
}