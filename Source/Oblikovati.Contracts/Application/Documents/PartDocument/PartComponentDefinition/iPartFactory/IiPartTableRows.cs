namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.iPartFactory;

public interface IiPartTableRows : IList<IiPartTableRows>
{
    IiPartTableRow Item { get; }
}