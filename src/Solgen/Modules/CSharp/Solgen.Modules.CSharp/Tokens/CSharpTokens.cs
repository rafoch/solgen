using Solgen.Shared.Abstractions.Tokens;

namespace Solgen.Modules.CSharp.Tokens;

public class CSharpTokens 
{
    
    class ProjectToken : TokenWithIdentifier
    {
        public override string Value => "csharp";
        public override string Type => nameof(ProjectToken);
    }

    class SlnToken : TokenWithIdentifier
    {
        public override string Value => "sln";
        public override string Type => nameof(SlnToken);
    }

    class FolderToken : TokenWithIdentifier
    {
        public override string Value => "folder";
        public override string Type => nameof(FolderToken);
    }


    public IEnumerable<Token> GetTokens()
    {
        yield return new ProjectToken();
        yield return new SlnToken();
        yield return new FolderToken();
    }
}