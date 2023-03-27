namespace Oblikovati.Domain.Contracts;

public interface IiFeatureTableColumn : IList<IiFeatureTableColumn>
{
    IiFeatureTable Parent { get; }

    int Count { get; }
    IiFeatureTableCell Item { get; }
    string DisplayHeading { get; }
    string FormattedHeading { get; }
    string Heading { get; }
    int Index { get; }
    int Key { get; set; }
    bool CustomColumn { get; set; }
    string CustomIncrement { get; set; }
    string CustomRangeMaximum { get; set; }
    string CustomRangeMinimum { get; set; }
    IEnumerator GetEnumerator();
    void Delete();
}
