using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts.Delegates;

public delegate void ModelingEventsSink_OnClientFeatureDoubleClickEventHandler(IDocument Document, IClientFeature Feature, INameValueMap Context, out HandlingCodeEnum HandlingCode);
