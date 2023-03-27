﻿namespace Oblikovati.Domain.Contracts;

public interface ISplineFitPointConstraint
{

    ISketch Parent { get; }
    IAttributeSets AttributeSets { get; }
    bool Deletable { get; }
    ISketchSpline Spline { get; }
    ISketchPoint Point { get; }
    void Delete();
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
}
