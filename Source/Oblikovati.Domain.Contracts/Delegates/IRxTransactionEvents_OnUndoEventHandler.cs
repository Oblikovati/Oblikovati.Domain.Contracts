using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts.Delegates;

public delegate void IRxTransactionEvents_OnUndoEventHandler(ITransaction Transaction, EventTimingEnum BeforeOrAfter, out HandlingCodeEnum HandlingCode);
