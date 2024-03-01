using Solgen.Modules.CSharp.Tokens;
using Solgen.Shared.Abstractions.Parser;
using Solgen.Shared.Abstractions.Tokens;

namespace Solgen.Modules.CSharp.Parser;

public class FolderParser : IParser
{
    public Token OpenSectionToken => new FolderToken();
    public Token CloseSectionToken => new BaseTokenizer.CloseBracket();
    public object Parse(IList<TokenResult> tokens)
    {
        var solution = tokens
            .FirstOrDefault(x => x.Token.Value == OpenSectionToken.Value &&
                                 x.Token.Type == OpenSectionToken.Type);

        if (solution is null)
        {
            return null;
        }

        var solutionDepth = solution.Depth;

        var findCloseToken = tokens
            .First(x => x.Depth == solutionDepth &&
                        x.Token.Value == CloseSectionToken.Value &&
                        x.Token.Type == CloseSectionToken.Type);

        var tokensToParse = tokens
            .Where(x => x.TokenIndex >= solution.TokenIndex && x.TokenIndex <= findCloseToken.TokenIndex)
            .ToList();

        return tokensToParse;
    }
}