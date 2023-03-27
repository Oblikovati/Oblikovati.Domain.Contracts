﻿using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts.Delegates;

public delegate void SketchEventsSink_OnDeleteEventHandler(IDocument Document, object Entity, EventTimingEnum BeforeOrAfter, INameValueMap Context, out HandlingCodeEnum HandlingCode);
