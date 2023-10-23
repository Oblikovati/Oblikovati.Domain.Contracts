using Oblikovati.Contracts.Application.TransientObjects.Math;
using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application;

public interface IManipulatorEventsSink
{
    void OnManipulatorElementSelectionChange(ManipulatorElementEnum SelectedManipulatorElement,
        EventTiming BeforeOrAfter, INameValueMap Context, out HandlingCodeEnum HandlingCode);

    void OnStartDrag(ManipulatorElementEnum SelectedManipulatorElement, EventTiming BeforeOrAfter,
        INameValueMap Context, out HandlingCodeEnum HandlingCode);

    void OnEndDrag(ManipulatorElementEnum SelectedManipulatorElement, object DragValue, IMatrix ManipulatorTransform,
        EventTiming BeforeOrAfter, INameValueMap Context, out HandlingCodeEnum HandlingCode);

    void OnDrag(ManipulatorElementEnum SelectedManipulatorElement, object DragValue, IMatrix ManipulatorTransform,
        INameValueMap Context, out HandlingCodeEnum HandlingCode);
}