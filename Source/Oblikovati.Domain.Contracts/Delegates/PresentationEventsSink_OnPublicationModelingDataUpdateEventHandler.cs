using Oblikovati.Domain.Contracts;
using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts.Delegates;

public delegate void PresentationEventsSink_OnPublicationModelingDataUpdateEventHandler(IPublication Publication, CommandTypesEnum ReasonsForChange, EventTimingEnum BeforeOrAfter, INameValueMap Context, out HandlingCodeEnum HandlingCode);
