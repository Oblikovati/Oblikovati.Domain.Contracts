using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts.Delegates;

public delegate void MiniToolbarSink_OnEndMoveEventHandler(INameValueMap Context, out HandlingCodeEnum HandlingCode);
