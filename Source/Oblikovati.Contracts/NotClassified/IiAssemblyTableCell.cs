namespace Oblikovati.Contracts.NotClassified;

public interface IiAssemblyTableCell
{
    IiAssemblyFactory Parent { get; }
    string Value { get; set; }
    int Row { get; }
    int Column { get; }
    bool HasFormula { get; }
    bool IsValid { get; }
}