using Oblikovati.Domain.Contracts;
using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts.Delegates;

public delegate void MiniToolbarSink_OnMoveEventHandler(INameValueMap Context, out HandlingCodeEnum HandlingCode);
