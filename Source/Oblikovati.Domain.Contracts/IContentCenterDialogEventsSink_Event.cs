using Oblikovati.Domain.Contracts.Delegates;

namespace Oblikovati.Domain.Contracts;

public interface IContentCenterDialogEventsSink_Event
{
    void add_OnSelect(ContentCenterDialogEventsSink_OnSelectEventHandler handler);
    void remove_OnSelect(ContentCenterDialogEventsSink_OnSelectEventHandler handler);
    void add_OnSelectionCommit(ContentCenterDialogEventsSink_OnSelectionCommitEventHandler handler);
    void remove_OnSelectionCommit(ContentCenterDialogEventsSink_OnSelectionCommitEventHandler handler);
    void add_OnTerminate(ContentCenterDialogEventsSink_OnTerminateEventHandler handler);
    void remove_OnTerminate(ContentCenterDialogEventsSink_OnTerminateEventHandler handler);
}
