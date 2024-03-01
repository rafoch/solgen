using System.Collections.Generic;
using System.Linq;

namespace Solgen.Shared.Abstractions.Tokens;

public interface ITokenizer
{
    // public IEnumerable<TokenResult> GetTokens(string word, int depth);
}

public abstract class BaseTokenizer : ITokenizer
{
    private readonly List<Token> _tokens;
    private readonly OpenBracket _openBracket;
    private readonly CloseBracket _closeBracket;

    
    class OpenBracket : TokenWithoutIdentifier
    {
        public override string Value => "{";
        public override bool HasIdentifier { get; }
        public override string Type => nameof(OpenBracket);
    }
    
    class CloseBracket : TokenWithoutIdentifier
    {
        public override string Value => "}";
        public override string Type => nameof(CloseBracket);
    }


    public BaseTokenizer()
    {
        _openBracket = new OpenBracket();
        _closeBracket = new CloseBracket();
        _tokens = new List<Token>()
        {
            _openBracket,
            _closeBracket
        };
    }
    
    public abstract IEnumerable<TokenResult> GetTokens(string word, ref int depth, ref int tokenIndex);

    public abstract IEnumerable<Token> GetAvailableTokens();

    protected IEnumerable<Token> GetBaseToken(string word, ref int depth)
    {
        if (word == _openBracket.Value)
        {
            depth += 1;
        }
        else if (word == _closeBracket.Value)
        {
            depth -= 1;
        }
        return _tokens.Where(x => x.Value == word);
    }

    protected IEnumerable<Token> GetBaseAvailableTokens()
    {
        return _tokens;
    }
}

public record TokenResult(Token Token, int Depth, int TokenIndex);