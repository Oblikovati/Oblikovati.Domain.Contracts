namespace Oblikovati.Contracts.Application.Documents.Document.BrowserPanes;

public interface IBrowserNodesEnumerator : IList<IBrowserNode>
{
    IBrowserNode ItemById(int Id);
}