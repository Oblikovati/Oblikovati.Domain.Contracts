namespace Oblikovati.Contracts.NotClassified;

public interface ITestResults : IList<ITestResults>
{
    ITestResult Item { get; }


    void Refresh();
}