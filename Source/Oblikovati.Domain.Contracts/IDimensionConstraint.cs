﻿namespace Oblikovati.Domain.Contracts;

public interface IDimensionConstraint
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
    void Delete();
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
}