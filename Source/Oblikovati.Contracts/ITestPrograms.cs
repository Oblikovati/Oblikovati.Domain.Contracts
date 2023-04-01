namespace Oblikovati.Contracts;

public interface ITestPrograms : IList<ITestPrograms>
{
    ITestProgram Item { get; }


    void Refresh();
}