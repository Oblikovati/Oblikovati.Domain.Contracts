namespace Oblikovati.Contracts.NotClassified;

public interface ITestCases : IList<ITestCases>
{
    ITestCase Item { get; }


    void Refresh();
}