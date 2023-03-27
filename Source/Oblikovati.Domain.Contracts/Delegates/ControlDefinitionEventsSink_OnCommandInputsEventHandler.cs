using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts.Delegates;

public delegate void ControlDefinitionEventsSink_OnCommandInputsEventHandler(EventTimingEnum BeforeOrAfter, INameValueMap Context, out INameValueMap Inputs, out HandlingCodeEnum HandlingCode);
