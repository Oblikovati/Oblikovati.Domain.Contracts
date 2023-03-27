using Oblikovati.Domain.Contracts.Delegates;

namespace Oblikovati.Domain.Contracts;

public interface IProjectOptionsButtonSink_Event
{
    void add_OnClick(ProjectOptionsButtonSink_OnClickEventHandler handler);
    void remove_OnClick(ProjectOptionsButtonSink_OnClickEventHandler handler);
}
