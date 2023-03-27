using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts.Delegates;

public delegate void AssemblyEventsSink_OnLoadStateChangeEventHandler(I_AssemblyDocument Document, DocumentLoadStateEnum NewLoadState, EventTimingEnum BeforeOrAfter, INameValueMap Context, out HandlingCodeEnum HandlingCode);
