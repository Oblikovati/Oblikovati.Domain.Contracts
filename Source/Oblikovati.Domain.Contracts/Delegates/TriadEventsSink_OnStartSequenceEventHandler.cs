﻿using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts.Delegates;

public delegate void TriadEventsSink_OnStartSequenceEventHandler(IMatrix CoordinateSystem, INameValueMap Context, out HandlingCodeEnum HandlingCode);
