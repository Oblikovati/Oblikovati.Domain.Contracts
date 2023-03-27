namespace Oblikovati.Domain.Contracts;

public interface IModelStateTableCell
{

    IModelStateTable Parent { get; }
    int Column { get; }
    int Row { get; }
    bool HasFormula { get; }
    bool IsValid { get; }
    string Value { get; set; }
}
