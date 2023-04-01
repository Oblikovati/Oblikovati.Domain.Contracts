using Oblikovati.Contracts.Application.TransientObjects.Utility;

namespace Oblikovati.Contracts;

public interface ICustomDataEventsSink
{
    void OnRequestCustomData(INameValueMap Context, out INameValueMap CustomData);
    void OnExecuteCustomAction(INameValueMap Context, INameValueMap CustomData);
}