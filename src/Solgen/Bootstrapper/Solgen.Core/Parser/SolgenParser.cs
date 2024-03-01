using System.Collections.ObjectModel;
using Solgen.Modules.CSharp.Parser;
using Solgen.Shared.Abstractions.Parser;
using Solgen.Shared.Abstractions.Tokens;

namespace Solgen.Core.Parser;

public class SolgenParser : IParser
{
    private readonly IReadOnlyCollection<IParser> _parsers;
    public SolgenParser()
    {
        _parsers = new List<IParser>(new []{ new SlnParser() });
    }

    public Token OpenSectionToken { get; } //TODO Remove for futher readability
    public Token CloseSectionToken { get; } //TODO Remove for futher readability

    public object Parse(IList<TokenResult> tokens)
    {
        foreach (var parser in _parsers)
        {
            var o = parser.Parse(tokens);
            return o;
        }

        return new string("");
    }
}