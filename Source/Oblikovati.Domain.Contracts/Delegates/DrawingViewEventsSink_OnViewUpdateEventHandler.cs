using Oblikovati.Domain.Contracts;
using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts.Delegates;

public delegate void DrawingViewEventsSink_OnViewUpdateEventHandler(EventTimingEnum BeforeOrAfter, INameValueMap Context, CommandTypesEnum ReasonsForChange, out HandlingCodeEnum HandlingCode);
