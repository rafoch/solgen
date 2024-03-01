using System.Collections.Generic;
using Solgen.Shared.Abstractions.Tokens;

namespace Solgen.Shared.Abstractions.Parser;

public interface IParser
{
    public Token OpenSectionToken { get; }
    public Token CloseSectionToken { get; }
    public object Parse(IList<TokenResult> tokens);
}