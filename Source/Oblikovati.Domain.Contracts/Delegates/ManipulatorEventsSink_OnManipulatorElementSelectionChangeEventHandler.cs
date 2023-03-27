using Oblikovati.Domain.Contracts;
using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts.Delegates;

public delegate void ManipulatorEventsSink_OnManipulatorElementSelectionChangeEventHandler(ManipulatorElementEnum SelectedManipulatorElement, EventTimingEnum BeforeOrAfter, INameValueMap Context, out HandlingCodeEnum HandlingCode);
