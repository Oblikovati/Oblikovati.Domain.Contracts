using Oblikovati.Contracts.Application.TransientObjects.Utility;

namespace Oblikovati.Contracts;

public interface IProjectOptionsButtonSink
{
    void OnClick(INameValueMap Context);
}