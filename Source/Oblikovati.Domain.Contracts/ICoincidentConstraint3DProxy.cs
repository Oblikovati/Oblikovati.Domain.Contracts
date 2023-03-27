﻿namespace Oblikovati.Domain.Contracts;

public interface ICoincidentConstraint3DProxy
{

    ISketch3D Parent { get; }
    IAttributeSets AttributeSets { get; }
    bool Deletable { get; }
    ISketchPoint3D SketchPoint { get; }
    IVertex Vertex { get; }
    IWorkPoint WorkPoint { get; }
    object EntityOne { get; }
    object EntityTwo { get; }
    object ConnectedEntity { get; }
    ICoincidentConstraint3D NativeObject { get; }
    IComponentOccurrence ContainingOccurrence { get; }
    void Delete();
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    void Disconnect(object Entity);
}
