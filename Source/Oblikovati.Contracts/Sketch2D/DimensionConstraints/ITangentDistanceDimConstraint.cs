﻿using Oblikovati.Contracts.Application.TransientGeometry;
using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Attributes;
using Oblikovati.Contracts.Parameters;

namespace Oblikovati.Contracts.Sketch2D.DimensionConstraints;

public interface ITangentDistanceDimConstraint
{
    ISketch Parent { get; }
    IPoint2d TextPoint { get; set; }
    bool Driven { get; set; }
    IParameter Parameter { get; }
    IAttributeSets AttributeSets { get; }
    double _DisplayValue { get; set; }
    bool Visible { get; set; }
    IPoint2d DimensionCenterPoint { get; }
    IObjectCollection AnchorPoints { get; }
    ISketchEntity EntityOne { get; }
    ISketchEntity EntityTwo { get; }
    bool LinearDiameter { get; }
    IPoint2d ProximityPointOne { get; }
    IPoint2d ProximityPointTwo { get; }
    void Delete();
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
}