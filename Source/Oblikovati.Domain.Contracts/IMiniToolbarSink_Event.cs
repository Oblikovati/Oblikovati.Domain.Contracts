using Oblikovati.Domain.Contracts.Delegates;

namespace Oblikovati.Domain.Contracts;

public interface IMiniToolbarSink_Event
{
    void add_OnApply(MiniToolbarSink_OnApplyEventHandler handler);
    void remove_OnApply(MiniToolbarSink_OnApplyEventHandler handler);
    void add_OnCancel(MiniToolbarSink_OnCancelEventHandler handler);
    void remove_OnCancel(MiniToolbarSink_OnCancelEventHandler handler);
    void add_OnOK(MiniToolbarSink_OnOKEventHandler handler);
    void remove_OnOK(MiniToolbarSink_OnOKEventHandler handler);
    void add_OnStartMove(MiniToolbarSink_OnStartMoveEventHandler handler);
    void remove_OnStartMove(MiniToolbarSink_OnStartMoveEventHandler handler);
    void add_OnMove(MiniToolbarSink_OnMoveEventHandler handler);
    void remove_OnMove(MiniToolbarSink_OnMoveEventHandler handler);
    void add_OnEndMove(MiniToolbarSink_OnEndMoveEventHandler handler);
    void remove_OnEndMove(MiniToolbarSink_OnEndMoveEventHandler handler);
    void add_OnHide(MiniToolbarSink_OnHideEventHandler handler);
    void remove_OnHide(MiniToolbarSink_OnHideEventHandler handler);
    void add_OnShow(MiniToolbarSink_OnShowEventHandler handler);
    void remove_OnShow(MiniToolbarSink_OnShowEventHandler handler);
}
