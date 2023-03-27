namespace Oblikovati.Domain.Contracts;

public interface IClientResourceMap
{

    string ClientId { get; }
    int Id { get; }
    string Description { get; set; }

    void SetBrowserIconData(INameValueMap IconData, string Theme, object AsDefault);
    void Delete();
}
