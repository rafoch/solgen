using System.Collections.Generic;
using System.Linq;

namespace Solgen.Shared.Abstractions.Tokens;

public interface ITokenizer
{
    public IEnumerable<TokenResult> GetTokens(string word, int depth);
}

public abstract class BaseTokenizer : ITokenizer
{
    private readonly List<Token> _tokens;

    class Identifier : Token
    {
        public override string Value => "";
    }

    class OpenBracket : Token
    {
        public override string Value => "{";
    }
    
    class CloseBracket : Token
    {
        public override string Value => "}";
    }


    public BaseTokenizer()
    {
        _tokens = new List<Token>()
        {
            new OpenBracket(),
            new CloseBracket()
        };
    }
    
    public abstract IEnumerable<TokenResult> GetTokens(string word, int depth);

    protected IEnumerable<Token> GetBaseToken(string word, ref int depth)
    {
        if (word == "{")
        {
            depth += 1;
        }
        else if (word == "}")
        {
            depth -= 1;
        }
        return _tokens.Where(x => x.Value == word);
    }
}

public record TokenResult(Token Token, int Depth, string? Identifier);