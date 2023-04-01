﻿using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.Documents.Document.BrowserPanes;

public interface IBrowserNodeDefinitionSink
{
    void OnLabelEdit(string NewLabel, EventTimingEnum BeforeOrAfter, INameValueMap Context,
        out HandlingCodeEnum HandlingCode);
}