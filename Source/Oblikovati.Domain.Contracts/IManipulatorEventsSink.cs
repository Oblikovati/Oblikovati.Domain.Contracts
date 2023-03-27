using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IManipulatorEventsSink
{
    void OnManipulatorElementSelectionChange(ManipulatorElementEnum SelectedManipulatorElement, EventTimingEnum BeforeOrAfter, INameValueMap Context, out HandlingCodeEnum HandlingCode);
    void OnStartDrag(ManipulatorElementEnum SelectedManipulatorElement, EventTimingEnum BeforeOrAfter, INameValueMap Context, out HandlingCodeEnum HandlingCode);
    void OnEndDrag(ManipulatorElementEnum SelectedManipulatorElement, object DragValue, IMatrix ManipulatorTransform, EventTimingEnum BeforeOrAfter, INameValueMap Context, out HandlingCodeEnum HandlingCode);
    void OnDrag(ManipulatorElementEnum SelectedManipulatorElement, object DragValue, IMatrix ManipulatorTransform, INameValueMap Context, out HandlingCodeEnum HandlingCode);
}
