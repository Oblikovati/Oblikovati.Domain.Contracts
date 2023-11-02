namespace Oblikovati.Contracts.NotClassified;

public interface ITestResult
{
    ITestCase Parent { get; }
    string ValidationText { get; }
    bool Succeeded { get; }
    bool Compare { get; }
}