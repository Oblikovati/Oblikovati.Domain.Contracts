using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts.Delegates;

public delegate void ModelingEventsSink_OnClientFeatureSolveEventHandler(IDocument Document, IClientFeature Feature, EventTimingEnum BeforeOrAfter, INameValueMap Context, out HandlingCodeEnum HandlingCode);
