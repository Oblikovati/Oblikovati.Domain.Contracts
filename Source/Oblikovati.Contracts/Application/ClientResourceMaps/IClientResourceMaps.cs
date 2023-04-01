namespace Oblikovati.Contracts.Application.ClientResourceMaps;

public interface IClientResourceMaps : IList<IClientResourceMap>
{
    IClientResourceMap Add(string ClientId, int Id);
    IClientResourceMap ItemById(string ClientId, int Id);
}