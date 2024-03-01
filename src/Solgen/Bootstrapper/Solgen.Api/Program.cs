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

var app = builder.Build();

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

app.MapGet("/tokens", () =>
    {
        var tokens = tokenizer.GetTokens(exampleStructure);
        return Results.Ok(tokens);
    })
    .WithName("Tokens")
    .WithOpenApi();

app.MapGet("/parser", () =>
    {
        var tokens = tokenizer.GetTokens(exampleStructure);
        var @object = parser.Parse(tokens.ToList());
        return Results.Ok(@object);
    })
    .WithName("Parser")
    .WithOpenApi();

app.Run();


