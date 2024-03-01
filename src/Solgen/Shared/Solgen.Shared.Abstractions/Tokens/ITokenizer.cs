using System.Collections.Generic;

namespace Solgen.Shared.Abstractions.Tokens;

public interface ITokenizer
{
    public IEnumerable<Token> GetTokens(string word);
}