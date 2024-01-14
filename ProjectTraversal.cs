using Microsoft.Build.Graph;

namespace Honlsoft.Samples.ProjectTraversal;

public class ProjectTraversal {

    public void Run(string[] args) {

        // Make sure the files exist
        var invalidFiles = args.Where((f) => !File.Exists(f)).ToArray();
        if (invalidFiles.Any()) {
            Console.WriteLine("The following files do not exist:");
            foreach (var file in invalidFiles) {
                Console.WriteLine(file);
            }
            return;
        }

        // Load the project graph
        ProjectGraph projectGraph = new ProjectGraph(args);

        // Get the unique projects in the graph
        var uniqueProjects = projectGraph.ProjectNodes.Select((p) => p.ProjectInstance.FullPath).Distinct().ToArray();

        // Display all the projects in the project graph to the console
        foreach (var project in uniqueProjects) {
            Console.WriteLine(project);
        }

    }
}