using Oblikovati.Domain.Contracts.Delegates;

namespace Oblikovati.Domain.Contracts;

public interface IMiniToolbarSliderSink_Event
{
    void add_OnValueChange(MiniToolbarSliderSink_OnValueChangeEventHandler handler);
    void remove_OnValueChange(MiniToolbarSliderSink_OnValueChangeEventHandler handler);
}
