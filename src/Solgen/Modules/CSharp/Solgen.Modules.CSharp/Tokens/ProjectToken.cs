using Solgen.Shared.Abstractions.Tokens;

namespace Solgen.Modules.CSharp.Tokens;

internal class ProjectToken : TokenWithIdentifier
{
    public override string Value => "csharp";
    public override string Type => nameof(ProjectToken);
}