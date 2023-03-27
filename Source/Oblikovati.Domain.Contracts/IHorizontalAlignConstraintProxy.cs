﻿namespace Oblikovati.Domain.Contracts;

public interface IHorizontalAlignConstraintProxy
{

    ISketch Parent { get; }
    IAttributeSets AttributeSets { get; }
    bool Deletable { get; }
    ISketchPoint PointOne { get; }
    ISketchPoint PointTwo { get; }
    IHorizontalAlignConstraint NativeObject { get; }
    IComponentOccurrence ContainingOccurrence { get; }
    void Delete();
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
}
