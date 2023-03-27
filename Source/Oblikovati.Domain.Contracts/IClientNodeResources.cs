namespace Oblikovati.Domain.Contracts;

public interface IClientNodeResources : IList<IClientNodeResource>
{

    IClientNodeResource ItemById(string ClientId, int Id);
    IClientNodeResource AddNodeResource(string ClientId, int Id, string IconName);
}
