using Oblikovati.Domain.Contracts.Delegates;

namespace Oblikovati.Domain.Contracts;

public interface IButtonDefinitionHandlerEventsSink_Event
{
    void add_OnClick(ButtonDefinitionHandlerEventsSink_OnClickEventHandler handler);
    void remove_OnClick(ButtonDefinitionHandlerEventsSink_OnClickEventHandler handler);
}
