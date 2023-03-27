namespace Oblikovati.Domain.Contracts;

public interface ITestPrograms : IList<ITestPrograms>
{
    ITestProgram Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
    void Refresh();
}
