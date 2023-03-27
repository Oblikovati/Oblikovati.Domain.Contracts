namespace Oblikovati.Domain.Contracts;

public interface ITestResults : IList<ITestResults>
{
    ITestResult Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
    void Refresh();
}
