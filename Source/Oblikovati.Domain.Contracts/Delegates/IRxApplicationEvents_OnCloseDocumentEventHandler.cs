using Oblikovati.Domain.Contracts;
using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts.Delegates;

public delegate void IRxApplicationEvents_OnCloseDocumentEventHandler(IDocument Document, EventTimingEnum BeforeOrAfter);
