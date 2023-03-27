using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts.Delegates;

public delegate void TransactionEventsSink_OnDeleteEventHandler(ITransaction Transaction, INameValueMap Context, EventTimingEnum BeforeOrAfter);
