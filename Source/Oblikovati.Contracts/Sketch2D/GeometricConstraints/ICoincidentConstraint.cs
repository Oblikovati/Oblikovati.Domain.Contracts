﻿using Oblikovati.Contracts.Attributes;

namespace Oblikovati.Contracts.Sketch2D.GeometricConstraints;

public interface ICoincidentConstraint
{
    ISketch Parent { get; }
    IAttributeSets AttributeSets { get; }
    bool Deletable { get; }
    ISketchEntity EntityOne { get; }
    ISketchEntity EntityTwo { get; }
    bool StartOrEndPointConstraint { get; }
    void Delete();
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
}