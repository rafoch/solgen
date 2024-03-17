using Solgen.Core.Tokens;

namespace Solgen.Api.Services;

public class TokenizeService
{
    private readonly SolgenTokenizer _tokenizer;

    public TokenizeService()
    {
        _tokenizer = new SolgenTokenizer();
    }
    public async Task GetTokens(string input)
    {
        var tokens = _tokenizer.GetTokens(input);
    }
}