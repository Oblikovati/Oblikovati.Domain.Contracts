namespace Oblikovati.Contracts.Application.Documents.Document.BrowserPanes;

public interface IClientNodeResources : IList<IClientNodeResource>
{
    IClientNodeResource ItemById(string ClientId, int Id);
    IClientNodeResource AddNodeResource(string ClientId, int Id, string IconName);
}