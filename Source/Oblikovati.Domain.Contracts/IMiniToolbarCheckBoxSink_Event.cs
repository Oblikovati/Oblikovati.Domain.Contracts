using Oblikovati.Domain.Contracts.Delegates;

namespace Oblikovati.Domain.Contracts;

public interface IMiniToolbarCheckBoxSink_Event
{
    void add_OnClick(MiniToolbarCheckBoxSink_OnClickEventHandler handler);
    void remove_OnClick(MiniToolbarCheckBoxSink_OnClickEventHandler handler);
}
