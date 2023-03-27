using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IDrawingViewEventsSink
{
    void OnViewUpdate(EventTimingEnum BeforeOrAfter, INameValueMap Context, CommandTypesEnum ReasonsForChange, out HandlingCodeEnum HandlingCode);
}
