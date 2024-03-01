using Solgen.Shared.Abstractions.Tokens;

namespace Solgen.Modules.CSharp.Tokens;

public class CSharpTokenizer : BaseTokenizer
{
    
    private readonly IEnumerable<Token> _tokens = new CSharpTokens().GetTokens();
    public override IEnumerable<TokenResult> GetTokens(string word, ref int depth, ref int tokenIndex)
    {
        var baseTokens = base.GetBaseToken(word, ref depth);

        var tokenResults = new List<TokenResult>();

        if (baseTokens.Any())
        {
            tokenResults.Add(new TokenResult(baseTokens.First(), depth, tokenIndex));
            return tokenResults.AsEnumerable();
        }

        tokenIndex++;
        var tokens = _tokens.FirstOrDefault(token => token.Value == word);
        
        tokenResults.Add(new TokenResult(tokens, depth, tokenIndex));
        return tokenResults;
    }

    public override IEnumerable<Token> GetAvailableTokens()
    {
        var baseTokens = base.GetBaseAvailableTokens();

        var tokenList = baseTokens.ToList();
        tokenList.AddRange(_tokens);

        return tokenList;
    }
}