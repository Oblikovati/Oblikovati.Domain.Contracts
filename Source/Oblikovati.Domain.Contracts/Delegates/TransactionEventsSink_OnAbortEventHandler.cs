﻿using Oblikovati.Domain.Contracts;
using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts.Delegates;

public delegate void TransactionEventsSink_OnAbortEventHandler(ITransaction Transaction, INameValueMap Context, EventTimingEnum BeforeOrAfter);
