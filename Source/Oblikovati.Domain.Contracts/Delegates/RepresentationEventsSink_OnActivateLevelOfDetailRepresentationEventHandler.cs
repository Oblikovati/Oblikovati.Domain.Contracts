using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts.Delegates;

public delegate void RepresentationEventsSink_OnActivateLevelOfDetailRepresentationEventHandler(IDocument Document, ILevelOfDetailRepresentation Representation, EventTimingEnum BeforeOrAfter, INameValueMap Context, out HandlingCodeEnum HandlingCode);
