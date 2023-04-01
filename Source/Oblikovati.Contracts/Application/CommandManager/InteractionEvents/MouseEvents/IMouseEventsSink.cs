using Oblikovati.Contracts.Application.TransientGeometry;
using Oblikovati.Contracts.Application.Views;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.CommandManager.InteractionEvents.MouseEvents;

public interface IMouseEventsSink
{
    void OnMouseUp(MouseButtonEnum Button, ShiftStateEnum ShiftKeys, IPoint ModelPosition, IPoint2d ViewPosition,
        IView View);

    void OnMouseDown(MouseButtonEnum Button, ShiftStateEnum ShiftKeys, IPoint ModelPosition, IPoint2d ViewPosition,
        IView View);

    void OnMouseClick(MouseButtonEnum Button, ShiftStateEnum ShiftKeys, IPoint ModelPosition, IPoint2d ViewPosition,
        IView View);

    void OnMouseDoubleClick(MouseButtonEnum Button, ShiftStateEnum ShiftKeys, IPoint ModelPosition,
        IPoint2d ViewPosition, IView View);

    void OnMouseMove(MouseButtonEnum Button, ShiftStateEnum ShiftKeys, IPoint ModelPosition, IPoint2d ViewPosition,
        IView View);

    void OnMouseLeave(MouseButtonEnum Button, ShiftStateEnum ShiftKeys, IView View);
}