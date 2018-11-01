#tool "nuget:?package=xunit.runner.console"
// #tool "nuget:?package=JetBrains.dotCover.CommandLineTools"

var configuration = Argument("Configuration", "Release");
var solutionPath = Argument("SolutionPath", @"../Code/GodOfWar.sln");


Task("Clean")
    .Does(() =>
{
    CleanDirectories(string.Format("../Code/**/obj/{0}",configuration));
    CleanDirectories(string.Format("../Code/**/bin/{0}",configuration));
});

Task("Restore-Nuget")
    .Does(()=> {
        NuGetRestore(solutionPath);
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

    // DotCoverCover(tool => {
    // tool.XUnit2("../Code/**/bin/" +configuration + "/*.Tests.Unit.dll",
    // new XUnit2Settings {
    //   ShadowCopy = false
    // });
    // },
    // new FilePath("./TestResults/result.dcvr"),
    // new DotCoverCoverSettings()
    //     .WithFilter("+:UOM.*")
    //     .WithFilter("-:*.Tests.Unit"));

    // DotCoverReport(new FilePath("./TestResults/result.dcvr"),
    //     new FilePath("./TestResults/result.html"),
    //     new DotCoverReportSettings {
    //         ReportType = DotCoverReportType.HTML
    //     });
});

Task("Default")
    .IsDependentOn("Clean")
    .IsDependentOn("Restore-Nuget")
    .IsDependentOn("Build")
    .IsDependentOn("Run-Unit-Tests")
    ;

RunTarget("Default");
