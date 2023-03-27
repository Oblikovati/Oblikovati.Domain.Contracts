namespace Oblikovati.Domain.Contracts.Application.Headless;

public interface IHeadlessDocuments : IList<IHeadlessDocuments>
{
    IHeadlessDocument Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
}
