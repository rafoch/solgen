using Solgen.Shared.Abstractions.Tokens;

namespace Solgen.Modules.CSharp.Tokens;

internal class CSharpTokens 
{
    public IEnumerable<Token> GetTokens()
    {
        yield return new ProjectToken();
        yield return new SlnToken();
        yield return new FolderToken();
    }
}