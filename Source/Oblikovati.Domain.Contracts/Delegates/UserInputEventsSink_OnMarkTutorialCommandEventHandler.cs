using Oblikovati.Domain.Contracts;
using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts.Delegates;

public delegate void UserInputEventsSink_OnMarkTutorialCommandEventHandler(string CommandID, INameValueMap Context, out HandlingCodeEnum HandlingCode);
