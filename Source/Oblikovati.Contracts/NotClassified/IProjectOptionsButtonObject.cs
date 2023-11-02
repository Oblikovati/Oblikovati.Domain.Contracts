using Oblikovati.Contracts.Application.TransientObjects.Utility;

namespace Oblikovati.Contracts.NotClassified;

public interface IProjectOptionsButtonObject
{
    string DisplayName { get; set; }
    void FireOnClick(INameValueMap Context);
    void Delete();
}