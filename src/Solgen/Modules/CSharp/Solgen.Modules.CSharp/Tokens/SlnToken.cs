using Solgen.Shared.Abstractions.Tokens;

namespace Solgen.Modules.CSharp.Tokens;

internal class SlnToken : TokenWithIdentifier
{
    public override string Value => "sln";
    public override string Type => nameof(SlnToken);
}