using Oblikovati.Domain.Contracts.Delegates;

namespace Oblikovati.Domain.Contracts;

public interface IMiniToolbarButtonSink_Event
{
    void add_OnClick(MiniToolbarButtonSink_OnClickEventHandler handler);
    void remove_OnClick(MiniToolbarButtonSink_OnClickEventHandler handler);
}
