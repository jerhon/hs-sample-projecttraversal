
using Honlsoft.Samples.ProjectTraversal;
using Microsoft.Build.Locator;

// Register the default MSBuild SDK instance
var defaultInstance = MSBuildLocator.RegisterDefaults();
Console.WriteLine($"Using MSBuild at '{defaultInstance.MSBuildPath}' to load projects.");

// Run the project traversal
var projectTraversal = new ProjectTraversal();
projectTraversal.Run(args);
