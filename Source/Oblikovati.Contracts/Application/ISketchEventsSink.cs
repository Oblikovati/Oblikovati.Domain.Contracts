﻿using Oblikovati.Contracts.Application.Documents.Document;
using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Enums;
using Oblikovati.Contracts.Sketch2D;
using Oblikovati.Contracts.Sketch3D;

namespace Oblikovati.Contracts.Application;

public interface ISketchEventsSink
{
    void OnNewSketch(IDocument Document, ISketch Sketch, EventTimingEnum BeforeOrAfter, INameValueMap Context,
        out HandlingCodeEnum HandlingCode);

    void OnSketchChange(IDocument Document, ISketch Sketch, EventTimingEnum BeforeOrAfter, INameValueMap Context,
        out HandlingCodeEnum HandlingCode);

    void OnNewSketch3D(IDocument Document, ISketch3D Sketch3D, EventTimingEnum BeforeOrAfter, INameValueMap Context,
        out HandlingCodeEnum HandlingCode);

    void OnSketch3DChange(IDocument Document, ISketch3D Sketch3D, EventTimingEnum BeforeOrAfter, INameValueMap Context,
        out HandlingCodeEnum HandlingCode);

    void OnSketch3DSolve(IDocument Document, object Sketch, EventTimingEnum BeforeOrAfter, INameValueMap Context,
        out HandlingCodeEnum HandlingCode);

    void OnDelete(IDocument Document, object Entity, EventTimingEnum BeforeOrAfter, INameValueMap Context,
        out HandlingCodeEnum HandlingCode);
}