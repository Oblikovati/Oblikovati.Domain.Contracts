﻿namespace Oblikovati.Domain.Contracts.Enums;

public enum DrawingSheetStatusBits
{
    kUpToDateDrawingSheet,
    kGeomOutOfDateDrawingSheet,
    kAssyPositionOutOfDateDrawingSheet,
    kAssyCompositionOutOfDateDrawingSheet,
    kStandardOutOfDateDrawingSheet,
    kResourceTemplateOutOfDateDrawingSheet,
    kParameterizedTextOutOfDateDrawingSheet,
    kUnknownOutOfDateDrawingSheet,
    kNoDataDrawingSheet,
    kProcessingPreciseDisplayDrawingSheet,
}
