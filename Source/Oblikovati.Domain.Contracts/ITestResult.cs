namespace Oblikovati.Domain.Contracts;

public interface ITestResult
{
    ITestCase Parent { get; }
    string ValidationText { get; }
    bool Succeeded { get; }
    bool Compare { get; }
}
