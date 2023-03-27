namespace Oblikovati.Domain.Contracts;

public interface IProjectOptionsButtonObject
{
    string DisplayName { get; set; }
    void FireOnClick(INameValueMap Context);
    void Delete();
}
