using System.Text;

namespace Solgen.Modules.CSharp.Generators.Solution;

public class SolutionGenerator
{
    private const string SolutionTemplate = "";
    private const string ProjectDeclarationTemplate = "";
    private const string RuntimeDeclaration = "";
    private const string FolderDepthAssignementTemplate = "";
    public MemoryStream GenerateSolution(Solution solution)
    {
        var buildRuntimeDeclaration = BuildRuntimeDeclaration();
        var buildFolderDepthAssignement = BuildFolderDepthAssignement();
        var buildProjectDeclaration = BuildProjectDeclaration();
        var template = new string(SolutionTemplate);
        template = template.Replace("X", buildProjectDeclaration);
        template = template.Replace("X", buildFolderDepthAssignement);
        template = template.Replace("X", buildRuntimeDeclaration);


        var bytes = Encoding.UTF8.GetBytes(template);

        return new MemoryStream(bytes);
    }

    private string BuildProjectDeclaration()
    {
        //TODO  ProjectDeclarationTemplate.Replace()
        return String.Empty;
    }

    private string BuildRuntimeDeclaration()
    {
        return String.Empty;
    }

    private string BuildFolderDepthAssignement()
    {
        return String.Empty;
    }
}

public record Solution(List<SolutionItem> Items);

public record SolutionProject() : SolutionItem;
public record SolutionFolder(List<SolutionItem> Items) : SolutionItem;

public record SolutionItem();