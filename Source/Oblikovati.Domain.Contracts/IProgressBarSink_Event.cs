using Oblikovati.Domain.Contracts.Delegates;

namespace Oblikovati.Domain.Contracts;

public interface IProgressBarSink_Event
{
    void add_OnCancel(ProgressBarSink_OnCancelEventHandler handler);
    void remove_OnCancel(ProgressBarSink_OnCancelEventHandler handler);
}
