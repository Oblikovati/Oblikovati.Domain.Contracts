using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts.Delegates;

public delegate void TransactionEventsSink_OnCommitEventHandler(ITransaction Transaction, INameValueMap Context, EventTimingEnum BeforeOrAfter, out HandlingCodeEnum HandlingCode);
