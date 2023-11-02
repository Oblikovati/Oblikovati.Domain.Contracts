using Oblikovati.Contracts.Application.TransientObjects.Utility;

namespace Oblikovati.Contracts.NotClassified;

public interface IProjectOptionsButtonSink
{
    void OnClick(INameValueMap Context);
}