using Oblikovati.Domain.Contracts;
using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts.Delegates;

public delegate void IRxTransactionEvents_OnAbortEventHandler(ITransaction Transaction, EventTimingEnum BeforeOrAfter);
