namespace Oblikovati.Domain.Contracts;

public interface IiFeatureTableCell
{
    IiFeatureTable Parent { get; }

    IiFeatureTableColumn Column { get; }
    IiFeatureTableRow Row { get; }
    string Value { get; set; }
    bool HasFormula { get; }
    bool IsValid { get; }
    bool CustomCell { get; set; }
    string CustomIncrement { get; set; }
    string CustomRangeMaximum { get; set; }
    string CustomRangeMinimum { get; set; }
}
