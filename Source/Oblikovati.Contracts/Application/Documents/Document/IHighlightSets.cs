namespace Oblikovati.Contracts.Application.Documents.Document;

public interface IHighlightSets : IList<IHighlightSets>
{
    IHighlightSet Item { get; }

    IHighlightSet Add();
}