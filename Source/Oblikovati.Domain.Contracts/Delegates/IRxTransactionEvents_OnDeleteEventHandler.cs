using Oblikovati.Domain.Contracts;
using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts.Delegates;

public delegate void IRxTransactionEvents_OnDeleteEventHandler(ITransaction Transaction, EventTimingEnum BeforeOrAfter);
