using Oblikovati.Domain.Contracts;
using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts.Delegates;

public delegate void HelpEventsSink_OnApplicationHelpEventHandler(INameValueMap Context, out HandlingCodeEnum HandlingCode);
