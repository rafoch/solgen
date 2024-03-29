using Solgen.Api.Services;
using Solgen.Core.Parser;
using Solgen.Core.Tokens;

var exampleStructure = """
                       sln SolutionName {
                           folder DummyFolder {
                               csharp ProjectName {
                       
                               }
                       
                               csharp SecondProject {
                       
                                }
                           }
                           project ExampleProject {
                       
                           } 
                       }
                       """;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors();

builder.Services.AddSingleton<TokenizeService>();

var app = builder.Build();

app.UseCors(x => x.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

var parser = new SolgenParser();
var tokenizer = new SolgenTokenizer();

app.MapGet("/available-tokens", () =>
    {
        var tokens = tokenizer.GetAllAvailableTokens();
        return Results.Ok(tokens);
    })
    .WithName("Available-Tokens")
    .WithOpenApi();

app.MapPost("/tokenize", (TextEditor request) =>
    {
        var tokens = tokenizer.GetTokens(request.Data);
        return Results.Ok(tokens);
    })
    .WithName("Tokenize")
    .WithOpenApi();

app.MapPost("/parse", (TextEditor request) =>
    {
        var tokens = tokenizer.GetTokens(request.Data);
        var @object = parser.Parse(tokens.ToList());
        return Results.Ok(@object);
    })
    .WithName("Parser")
    .WithOpenApi();

app.MapPost("/download-zip", () =>
{
    return Results.Ok("empty response -> will be zip");
});

app.Run();


internal record TextEditor(string Data);