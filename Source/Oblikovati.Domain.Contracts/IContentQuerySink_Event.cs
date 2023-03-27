using Oblikovati.Domain.Contracts.Delegates;

namespace Oblikovati.Domain.Contracts;

public interface IContentQuerySink_Event
{
    void add_OnCancel(ContentQuerySink_OnCancelEventHandler handler);
    void remove_OnCancel(ContentQuerySink_OnCancelEventHandler handler);
    void add_OnDone(ContentQuerySink_OnDoneEventHandler handler);
    void remove_OnDone(ContentQuerySink_OnDoneEventHandler handler);
}
