﻿using Oblikovati.Contracts.Attributes;

namespace Oblikovati.Contracts.Sketch2D.GeometricConstraints;

public interface IConcentricConstraint
{
    ISketch Parent { get; }
    IAttributeSets AttributeSets { get; }
    bool Deletable { get; }
    ISketchEntity EntityOne { get; }
    ISketchEntity EntityTwo { get; }
    bool CenterPointConstraint { get; }
    void Delete();
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
}