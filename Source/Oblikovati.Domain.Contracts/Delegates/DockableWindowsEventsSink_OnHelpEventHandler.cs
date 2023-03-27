using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts.Delegates;

public delegate void DockableWindowsEventsSink_OnHelpEventHandler(IDockableWindow DockableWindow, INameValueMap Context, out HandlingCodeEnum HandlingCode);
