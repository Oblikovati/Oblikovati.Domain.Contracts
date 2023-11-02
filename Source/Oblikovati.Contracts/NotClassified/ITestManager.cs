namespace Oblikovati.Contracts.NotClassified;

public interface ITestManager
{
    ITestCases TestCases { get; }
    ITestPrograms TestPrograms { get; }
    ITestConfiguration TestConfiguration { get; }
    object TestHost { set; }
    object TestObject { set; }
    IEnumType GetEnumType(string EnumNameType);
}