using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts.Delegates;

public delegate void IRxDocumentEvents_OnCloseEventHandler(EventTimingEnum BeforeOrAfter);
