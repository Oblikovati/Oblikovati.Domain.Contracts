﻿using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts.Delegates;

public delegate void ModelingEventsSink_OnFeatureChangeEventHandler(IDocument Document, IPartFeature Feature, EventTimingEnum BeforeOrAfter, INameValueMap Context, out HandlingCodeEnum HandlingCode);