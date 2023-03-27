using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts.Delegates;

public delegate void DocumentSubTypeHandlerEventsSink_OnChangeTypeEventHandler(bool ConvertToSubType, IDocument Document, INameValueMap Context, out HandlingCodeEnum HandlingCode);
