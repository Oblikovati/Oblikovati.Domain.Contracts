﻿namespace Oblikovati.Domain.Contracts;

public interface IProjectedCut
{

    IAttributeSets AttributeSets { get; }
    string Name { get; set; }
    IPlanarSketch Parent { get; }
    ISketchEntitiesEnumerator SketchEntities { get; }
    void BreakLink();
    void Delete();
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
}