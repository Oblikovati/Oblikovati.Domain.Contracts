﻿using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts.Delegates;

public delegate void ModelingEventsSink_OnModelAnnotationsScaleChangeEventHandler(IDocument Document, EventTimingEnum BeforeOrAfter, INameValueMap Context, out HandlingCodeEnum HandlingCode);