using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IPathEntityProxy
{

    IPath Parent { get; }
    object Curve { get; }
    CurveTypeEnum CurveType { get; }
    object SketchEntity { get; }
    bool OpposedToSketchEntity { get; }
    IPathEntity NativeObject { get; }
    IComponentOccurrence ContainingOccurrence { get; }
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
}
