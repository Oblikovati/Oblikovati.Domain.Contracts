using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts.Delegates;

public delegate void RepresentationEventsSink_OnNewSectionViewEventHandler(IDocument Document, IDesignViewRepresentation Representation, EventTimingEnum BeforeOrAfter, INameValueMap Context, out HandlingCodeEnum HandlingCode);
