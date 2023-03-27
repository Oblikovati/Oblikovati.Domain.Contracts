using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts.Delegates;

public delegate void PublicationEventsSink_OnModelingDataUpdateEventHandler(I_PresentationDocument Document, IPublication Publication, EventTimingEnum BeforeOrAfter, out HandlingCodeEnum HandlingCode);
