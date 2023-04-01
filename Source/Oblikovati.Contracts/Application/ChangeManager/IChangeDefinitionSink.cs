using Oblikovati.Contracts.Application.TransientObjects.Utility;

namespace Oblikovati.Contracts.Application.ChangeManager;

public interface IChangeDefinitionSink
{
    void OnReplay(INameValueMap Context, out IChangeProcessor ResultProcessor);
}