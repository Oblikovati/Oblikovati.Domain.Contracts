using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IiAssemblyTableColumn : IList<IiAssemblyTableColumn>
{

    IiAssemblyFactory Parent { get; }
    int Count { get; }
    IiAssemblyTableCell Item { get; }
    int Index { get; }
    string Heading { get; }
    string DisplayHeading { get; }
    string FormattedHeading { get; }
    int Key { get; set; }
    iComponentColumnTypeEnum ReferencedDataType { get; }
    object ReferencedObject { get; }
    IEnumerator GetEnumerator();
    void Delete();
}
