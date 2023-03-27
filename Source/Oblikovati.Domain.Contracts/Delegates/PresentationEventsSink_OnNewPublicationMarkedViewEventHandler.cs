using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts.Delegates;

public delegate void PresentationEventsSink_OnNewPublicationMarkedViewEventHandler(I_PresentationDocument Document, IPublication PublicationObj, IPublicationMarkedView PublicationMarkedViewObj, EventTimingEnum BeforeOrAfter, INameValueMap Context, out HandlingCodeEnum HandlingCode);
