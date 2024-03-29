﻿using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.UserInterfaceManager.DockableWindows;

public interface IDockableWindowsEventsSink
{
    void OnHelp(IDockableWindow DockableWindow, INameValueMap Context, out HandlingCodeEnum HandlingCode);

    void OnHide(IDockableWindow DockableWindow, EventTiming BeforeOrAfter, INameValueMap Context,
        out HandlingCodeEnum HandlingCode);

    void OnShow(IDockableWindow DockableWindow, EventTiming BeforeOrAfter, INameValueMap Context,
        out HandlingCodeEnum HandlingCode);
}