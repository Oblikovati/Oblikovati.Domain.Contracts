using Oblikovati.Domain.Contracts;
using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts.Delegates;

public delegate void RepresentationEventsSink_OnNewDesignViewRepresentationEventHandler(I_AssemblyDocument Document, IDesignViewRepresentation Representation, EventTimingEnum BeforeOrAfter, INameValueMap Context, out HandlingCodeEnum HandlingCode);
