using Oblikovati.Domain.Contracts.Delegates;

namespace Oblikovati.Domain.Contracts;

public interface IContentCenterEventsSink_Event
{
    void add_OnRefreshStandardComponents(ContentCenterEventsSink_OnRefreshStandardComponentsEventHandler handler);
    void remove_OnRefreshStandardComponents(ContentCenterEventsSink_OnRefreshStandardComponentsEventHandler handler);
}
