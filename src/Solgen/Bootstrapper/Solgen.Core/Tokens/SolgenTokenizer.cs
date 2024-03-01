using Solgen.Modules.CSharp.Tokens;
using Solgen.Shared.Abstractions.Tokens;

namespace Solgen.Core.Tokens;

public class SolgenTokenizer
{
    private readonly List<ITokenizer> _tokenizers = new()
    {
        new CSharpTokenizer(),
    };

    public IEnumerable<TokenResult> GetTokens(string uml)
    {
        var umlWords = uml.Replace(System.Environment.NewLine, String.Empty).Split(' ');
        var depth = 1;
        var tokens = new List<TokenResult>();
        foreach (var word in umlWords)
        {
            foreach (var tokenizer in _tokenizers)
            {
                var result = tokenizer.GetTokens(word, depth);
                tokens.AddRange(result);
            }
        }

        return tokens.Where(x => x.Token != null);
    }
}