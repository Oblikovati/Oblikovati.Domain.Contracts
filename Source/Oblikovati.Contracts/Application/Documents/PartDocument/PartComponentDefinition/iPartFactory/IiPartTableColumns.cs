namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.iPartFactory;

public interface IiPartTableColumns : IList<IiPartTableColumns>
{
    IiPartTableColumn Item { get; }
}