namespace Oblikovati.Contracts;

public interface ITestCase
{
    string Name { get; }
    string Description { get; }
    ITestProgram Program { get; }
    string Path { get; }
    ITestResults TestResults { get; }
    string TestInputs { get; }
    ITestResult Baseline { get; }
    ITestResult Run(string ResultName, bool bDebug);
}