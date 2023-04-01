using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.ViewFramesEnumerator;

public interface IViewTabGroup : IList<IViewTab>
{
    IViewFrame ViewFrame { get; }
    void Close();
    IViewTabGroup MoveToGroup(IViewTab TargetViewTab, DockingStateEnum DockingState);

    IViewFrame MoveToNewViewFrame(object ViewFrameWidth, object ViewFrameHeight, object ViewFrameLeft,
        object ViewFrameTop);
}