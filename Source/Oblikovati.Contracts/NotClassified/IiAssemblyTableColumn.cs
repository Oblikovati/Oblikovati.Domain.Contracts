using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.NotClassified;

public interface IiAssemblyTableColumn : IList<IiAssemblyTableColumn>
{
    IiAssemblyFactory Parent { get; }

    IiAssemblyTableCell Item { get; }
    int Index { get; }
    string Heading { get; }
    string DisplayHeading { get; }
    string FormattedHeading { get; }
    int Key { get; set; }
    iComponentColumnTypeEnum ReferencedDataType { get; }
    object ReferencedObject { get; }

    void Delete();
}