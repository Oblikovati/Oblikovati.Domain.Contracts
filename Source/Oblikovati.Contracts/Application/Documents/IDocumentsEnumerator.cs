using Oblikovati.Contracts.Application.Documents.Document;

namespace Oblikovati.Contracts.Application.Documents;

public interface IDocumentsEnumerator : IList<IDocument>
{
    public IDocument this[string Index] { get; }
}