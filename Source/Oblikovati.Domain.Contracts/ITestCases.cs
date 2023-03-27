namespace Oblikovati.Domain.Contracts;

public interface ITestCases : IList<ITestCases>
{
    ITestCase Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
    void Refresh();
}
