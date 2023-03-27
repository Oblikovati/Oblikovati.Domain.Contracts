using Oblikovati.Domain.Contracts;
using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts.Delegates;

public delegate void WebBrowserDialogEventsSink_OnHelpEventHandler(INameValueMap Context, out HandlingCodeEnum HandlingCode);
