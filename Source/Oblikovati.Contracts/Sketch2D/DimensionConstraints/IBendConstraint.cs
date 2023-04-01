using Oblikovati.Contracts.Attributes;
using Oblikovati.Contracts.Parameters;
using Oblikovati.Contracts.Sketch3D;

namespace Oblikovati.Contracts.Sketch2D.DimensionConstraints;

public interface IBendConstraint
{
    ISketch3D Parent { get; }
    IAttributeSets AttributeSets { get; }
    bool Deletable { get; }
    ISketchArc3D Arc { get; }
    ISketchLine3D LineOne { get; }
    ISketchLine3D LineTwo { get; }
    IParameter Radius { get; }
    void Delete();
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
}