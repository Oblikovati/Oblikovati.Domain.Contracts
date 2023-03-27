using Oblikovati.Domain.Contracts.Delegates;

namespace Oblikovati.Domain.Contracts;

public interface IBalloonTipSink_Event
{
    void add_OnClick(BalloonTipSink_OnClickEventHandler handler);
    void remove_OnClick(BalloonTipSink_OnClickEventHandler handler);
    void add_OnDisplay(BalloonTipSink_OnDisplayEventHandler handler);
    void remove_OnDisplay(BalloonTipSink_OnDisplayEventHandler handler);
}
