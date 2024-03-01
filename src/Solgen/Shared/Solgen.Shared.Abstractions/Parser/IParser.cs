using System.Collections.Generic;
using Solgen.Shared.Abstractions.Tokens;

namespace Solgen.Shared.Abstractions.Parser;

public interface IParser
{
    public object Parse(IList<TokenResult> tokens);
}