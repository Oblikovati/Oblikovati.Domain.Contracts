using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IViewTabGroup : IList<IViewTab>
{

    IViewFrame ViewFrame { get; }
    void Close();
    IViewTabGroup MoveToGroup(IViewTab TargetViewTab, DockingStateEnum DockingState);
    IViewFrame MoveToNewViewFrame(object ViewFrameWidth, object ViewFrameHeight, object ViewFrameLeft, object ViewFrameTop);
}
