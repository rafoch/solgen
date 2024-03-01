using Solgen.Core.Parser;

var exampleStructure = """
                       sln SolutionName {
                           folder DummyFolder {
                               project ProjectName {
                       
                               }
                       
                               project SecondProject {
                       
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

app.MapGet("/", () =>
    {
        parser.Parse(exampleStructure);
        return Results.Ok();
    })
    .WithName("GetWeatherForecast")
    .WithOpenApi();

app.Run();


