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
        var umlWords = uml.Replace(System.Environment.NewLine, String.Empty).Split(' ').Where(x => x != String.Empty);
        var depth = 1;
        var tokenIndex = 0;
        var tokens = new List<TokenResult>();
        foreach (var word in umlWords)
        {
            foreach (var tokenizer in _tokenizers)
            {
                var result = tokenizer.GetTokens(word, ref depth, ref tokenIndex);
                
                tokens.AddRange(result);
                
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

    public IList<Token> GetAllAvailableTokens()
    {
        var tokens = _tokenizers.SelectMany(x => x.GetAvailableTokens()).ToList();

        return tokens;
    }
}