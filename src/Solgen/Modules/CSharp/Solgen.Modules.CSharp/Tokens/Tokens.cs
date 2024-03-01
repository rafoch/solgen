using Solgen.Shared.Abstractions.Tokens;

namespace Solgen.Modules.CSharp.Tokens;

public class CSharpTokens 
{
    class ProjectToken : Token
    {
        public override string Value => "csharp";
    }


    public IEnumerable<Token> GetTokens()
    {
        yield return new ProjectToken();
    }
}

public class CSharpTokenizer : ITokenizer
{
    
    private readonly IEnumerable<Token> _tokens = new CSharpTokens().GetTokens();
    public IEnumerable<Token> GetTokens(string word)
    {
        return _tokens.Where(token => token.Value == word);
    }
}