using System.Threading.Tasks;

namespace Solgen.Shared.Abstractions.Generator;

public interface IGenerator
{
    void Generate();
    Task GenerateAsync();
}