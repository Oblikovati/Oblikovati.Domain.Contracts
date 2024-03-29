﻿using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition;

public interface IPartEventsSink
{
    void OnSurfaceBodyChanged(INameValueMap Context, EventTiming BeforeOrAfter, out HandlingCodeEnum HandlingCode);
}