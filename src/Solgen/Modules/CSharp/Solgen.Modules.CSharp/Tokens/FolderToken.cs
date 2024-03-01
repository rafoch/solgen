using Solgen.Shared.Abstractions.Tokens;

namespace Solgen.Modules.CSharp.Tokens;

internal class FolderToken : TokenWithIdentifier
{
    public override string Value => "folder";
    public override string Type => nameof(FolderToken);
}