namespace Oblikovati.Domain.Contracts;

public interface IDocumentsEnumerator : IList<IDocument>
{
    public IDocument this[string Index] { get; }
}
