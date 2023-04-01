namespace Oblikovati.Contracts;

public interface ITestCases : IList<ITestCases>
{
    ITestCase Item { get; }


    void Refresh();
}