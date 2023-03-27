using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts.Delegates;

public delegate void PresentationEventsSink_OnPublicationComponentChangeEventHandler(I_PresentationDocument Document, IPublicationComponent PublicationComponent, EventTimingEnum BeforeOrAfter, INameValueMap Context, out HandlingCodeEnum HandlingCode);
