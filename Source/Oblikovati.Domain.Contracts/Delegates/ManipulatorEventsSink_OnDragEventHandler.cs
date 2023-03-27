using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts.Delegates;

public delegate void ManipulatorEventsSink_OnDragEventHandler(ManipulatorElementEnum SelectedManipulatorElement, object DragValue, IMatrix ManipulatorTransform, INameValueMap Context, out HandlingCodeEnum HandlingCode);
