using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.ClientGraphics.DrawingView;

public interface IDrawingViewEventsSink
{
    void OnViewUpdate(EventTiming BeforeOrAfter, INameValueMap Context, CommandTypesEnum ReasonsForChange,
        out HandlingCodeEnum HandlingCode);
}