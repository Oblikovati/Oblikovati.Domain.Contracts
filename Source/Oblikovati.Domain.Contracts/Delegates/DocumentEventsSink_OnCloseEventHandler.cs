﻿using Oblikovati.Domain.Contracts;
using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts.Delegates;

public delegate void DocumentEventsSink_OnCloseEventHandler(EventTimingEnum BeforeOrAfter, INameValueMap Context, out HandlingCodeEnum HandlingCode);