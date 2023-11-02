namespace Oblikovati.Contracts.NotClassified;

public interface ITestPrograms : IList<ITestPrograms>
{
    ITestProgram Item { get; }


    void Refresh();
}