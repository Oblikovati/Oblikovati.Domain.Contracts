﻿namespace Oblikovati.Domain.Contracts;

public interface IVerticalConstraint
{

    ISketch Parent { get; }
    IAttributeSets AttributeSets { get; }
    bool Deletable { get; }
    ISketchEntity Entity { get; }
    bool UseEllipseMajorAxis { get; }
    void Delete();
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
}
