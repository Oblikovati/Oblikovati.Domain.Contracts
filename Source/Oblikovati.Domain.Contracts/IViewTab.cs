using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IViewTab
{

    object View { get; }
    IViewFrame ViewFrame { get; }
    IViewTabGroup ViewTabGroup { get; }
    void Close();
    IViewTabGroup MoveToGroup(bool CreateNewGroup, IViewTab TargetViewTab, DockingStateEnum DockingState, object AdditionalViewTabs);
    IViewFrame MoveToNewViewFrame(object ViewFrameWidth, object ViewFrameHeight, object ViewFrameLeft, object ViewFrameTop, object AdditionalViewTabs);
}
