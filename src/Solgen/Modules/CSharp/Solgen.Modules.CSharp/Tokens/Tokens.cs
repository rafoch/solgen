using Solgen.Shared.Abstractions.Tokens;

namespace Solgen.Modules.CSharp.Tokens;

public class CSharpTokens 
{
    
    class ProjectToken : Token
    {
        public override string Value => "csharp";
    }

    class SlnToken : Token
    {
        public override string Value => "sln";
    }

    class FolderToken : Token
    {
        public override string Value => "folder";
    }


    public IEnumerable<Token> GetTokens()
    {
        yield return new ProjectToken();
        yield return new SlnToken();
        yield return new FolderToken();
    }
}

public class CSharpTokenizer : BaseTokenizer
{
    
    private readonly IEnumerable<Token> _tokens = new CSharpTokens().GetTokens();
    public override IEnumerable<TokenResult> GetTokens(string word, int depth)
    {
        List<TokenResult> tokenResults = new List<TokenResult>();
        var baseTokens = base.GetBaseToken(word, ref depth);

        if (baseTokens.Any())
        {
            yield return new TokenResult(baseTokens.First(), depth, String.Empty);
        }
        
        var tokens = _tokens.FirstOrDefault(token => token.Value == word);
        
        yield return new TokenResult(tokens, depth, String.Empty);
    }
}