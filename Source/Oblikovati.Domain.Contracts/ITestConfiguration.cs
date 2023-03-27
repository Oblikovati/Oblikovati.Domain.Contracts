namespace Oblikovati.Domain.Contracts;

public interface ITestConfiguration
{
    string InstallationType { get; set; }
    string TestDataLocation { get; set; }
    string TestProgramsLocation { get; set; }
    string TestCasesLocation { get; set; }
    string TestResultsLocation { get; set; }
}
