using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.ModelAnnotations;

public interface IModelStateTableColumn : IList<IModelStateTableColumn>
{
    IModelStateTableCell Item { get; }
    IModelStateTable Parent { get; }
    string Heading { get; }
    string DisplayHeading { get; }
    string FormattedHeading { get; }
    int Index { get; }
    iComponentColumnTypeEnum ReferencedDataType { get; }
    object ReferencedObject { get; }

    void Delete();
}