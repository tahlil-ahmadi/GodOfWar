#tool "nuget:?package=xunit.runner.console"

var configuration = Argument("Configuration", "Release");
var solutionPath = Argument("SolutionPath", @"../Code/GodOfWar.sln");


Task("Clean")
    .Does(() =>
{
    CleanDirectories(string.Format("../Code/**/obj/{0}",configuration));
    CleanDirectories(string.Format("../Code/**/bin/{0}",configuration));
});


Task("Build")
    .Does(()=>
{

    DotNetBuild(solutionPath, settings =>
        settings.SetConfiguration(configuration)
            .WithTarget("Build"));
});

Task("Run-Unit-Tests")
    .Does(()=>
{
    var testAssemblies = GetFiles("../Code/**/bin/"+configuration + "/*.Tests.Unit.dll");
    XUnit2(testAssemblies);
});

Task("Default")
    .IsDependentOn("Clean")
    .IsDependentOn("Build")
    .IsDependentOn("Run-Unit-Tests");

RunTarget("Default");
