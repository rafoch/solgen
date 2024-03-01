using System.Collections.Generic;

namespace Solgen.Shared.Abstractions.Tokens;

public abstract class TokenizerBase
{
    private const string OpenBracket = "{";
    private const string CloseBracket = "}";
    public virtual IEnumerable<string> GetTokens()
    {
        yield return OpenBracket;
        yield return CloseBracket;
    }
}