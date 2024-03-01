using Solgen.Modules.CSharp.Tokens;
using Solgen.Shared.Abstractions.Tokens;

namespace Solgen.Core.Tokens;

public class SolgenTokenizer : ITokenizer
{
    private readonly List<ITokenizer> _tokenizers = new()
    {
        new BaseTokenizer(),
        new CSharpTokenizer()
    };

    public IEnumerable<Token> GetTokens(string uml)
    {
        var umlWords = word.Split(' ');
        var depth = 1;
        foreach (var tokenizer in _tokenizers)
        {
            foreach (var word in umlWords)
            {
                tokenizer.GetTokens(word);
            }
        }

        return new List<Token>();
    }
}