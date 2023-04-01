using Oblikovati.Contracts.Application.TransientObjects.Utility;

namespace Oblikovati.Contracts.Application.UserInterfaceManager.BalloonTips;

public interface IBalloonTipSink
{
    void OnClick(INameValueMap Context);
    void OnDisplay(ref bool Cancel);
}