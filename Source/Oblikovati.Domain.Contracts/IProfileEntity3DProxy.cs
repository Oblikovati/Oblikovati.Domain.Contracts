using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IProfileEntity3DProxy
{

    IProfilePath3D Parent { get; }
    object Curve { get; }
    CurveTypeEnum CurveType { get; }
    ISketchEntity3D SketchEntity { get; }
    ISketchPoint3D StartSketchPoint { get; }
    ISketchPoint3D EndSketchPoint { get; }
    bool OpposedToSketchEntity { get; }
    IAttributeSets AttributeSets { get; }
    IProfileEntity3D NativeObject { get; }
    IComponentOccurrence ContainingOccurrence { get; }
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
}
