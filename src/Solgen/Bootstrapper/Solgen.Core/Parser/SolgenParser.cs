using System.Collections.ObjectModel;
using Solgen.Modules.CSharp.Parser;
using Solgen.Shared.Abstractions.Parser;

namespace Solgen.Core.Parser;

public class SolgenParser : IParser
{
    private readonly IReadOnlyCollection<IParser> _parsers;
    public SolgenParser()
    {
        _parsers = new List<IParser>(new []{ new CSharpParser() });
    }
    
    public void Parse(string uml)
    {
        foreach (var parser in _parsers)
        {
            parser.Parse(uml);
        }
    }
}