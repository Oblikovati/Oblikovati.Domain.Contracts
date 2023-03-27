using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts.Delegates;

public delegate void PresentationEventsSink_OnPublicationDesignViewChangeEventHandler(I_PresentationDocument Document, IPublication PublicationObj, EventTimingEnum BeforeOrAfter, INameValueMap Context, out HandlingCodeEnum HandlingCode);
