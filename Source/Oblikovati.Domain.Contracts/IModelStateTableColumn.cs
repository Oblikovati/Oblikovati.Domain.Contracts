using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IModelStateTableColumn : IList<IModelStateTableColumn>
{

    int Count { get; }
    IModelStateTableCell Item { get; }
    IModelStateTable Parent { get; }
    string Heading { get; }
    string DisplayHeading { get; }
    string FormattedHeading { get; }
    int Index { get; }
    iComponentColumnTypeEnum ReferencedDataType { get; }
    object ReferencedObject { get; }
    IEnumerator GetEnumerator();
    void Delete();
}
