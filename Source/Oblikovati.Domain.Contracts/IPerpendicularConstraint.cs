﻿namespace Oblikovati.Domain.Contracts;

public interface IPerpendicularConstraint
{

    ISketch Parent { get; }
    IAttributeSets AttributeSets { get; }
    bool Deletable { get; }
    ISketchEntity EntityOne { get; }
    ISketchEntity EntityTwo { get; }
    bool UseEllipseOneMajorAxis { get; }
    bool UseEllipseTwoMajorAxis { get; }
    void Delete();
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
}
