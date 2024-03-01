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
        _parsers = new List<IParser>(new []{ new CSharpParser() });
    }
    
    public object Parse(IList<TokenResult> tokens)
    {

        return new string("");
    }
}