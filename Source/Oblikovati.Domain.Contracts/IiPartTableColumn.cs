using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IiPartTableColumn : IList<IiPartTableColumn>
{

    int Count { get; }
    IiPartTableCell Item { get; }
    IiPartFactory Parent { get; }
    string Heading { get; }
    string DisplayHeading { get; }
    string FormattedHeading { get; }
    int Index { get; }
    bool CustomColumn { get; set; }
    string CustomIncrement { get; set; }
    string CustomRangeMaximum { get; set; }
    string CustomRangeMinimum { get; set; }
    int Key { get; set; }
    iComponentColumnTypeEnum ReferencedDataType { get; }
    object ReferencedObject { get; }
    IEnumerator GetEnumerator();
    void Delete();
}
