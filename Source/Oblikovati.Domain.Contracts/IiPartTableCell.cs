namespace Oblikovati.Domain.Contracts;

public interface IiPartTableCell
{

    IiPartFactory Parent { get; }
    string Value { get; set; }
    int Row { get; }
    int Column { get; }
    bool HasFormula { get; }
    bool IsValid { get; }
    bool CustomCell { get; set; }
    string CustomIncrement { get; set; }
    string CustomRangeMaximum { get; set; }
    string CustomRangeMinimum { get; set; }
}
