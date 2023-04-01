namespace Oblikovati.Contracts;

public interface ITestResults : IList<ITestResults>
{
    ITestResult Item { get; }


    void Refresh();
}