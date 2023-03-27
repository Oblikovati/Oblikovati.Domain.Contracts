using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts.Delegates;

public delegate void ManipulatorEventsSink_OnEndDragEventHandler(ManipulatorElementEnum SelectedManipulatorElement, object DragValue, IMatrix ManipulatorTransform, EventTimingEnum BeforeOrAfter, INameValueMap Context, out HandlingCodeEnum HandlingCode);
