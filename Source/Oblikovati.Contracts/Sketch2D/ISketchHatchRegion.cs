﻿using Oblikovati.Contracts.Application.Documents.DrawingDocument;
using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.NotClassified;
using Oblikovati.Contracts.Sketch2D.Profiles;

namespace Oblikovati.Contracts.Sketch2D;

public interface ISketchHatchRegion
{
    IDrawingSketch Parent { get; }
    double Angle { get; set; }
    IColor Color { get; set; }
    bool DoublePattern { get; set; }
    ILayer Layer { get; set; }
    double LineWeight { get; set; }
    IDrawingHatchPattern Pattern { get; set; }
    IProfile Profile { get; }
    double Scale { get; set; }
    double Shift { get; set; }
    void Delete();
}