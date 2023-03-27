using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IPathEntity
{

    IPath Parent { get; }
    object Curve { get; }
    CurveTypeEnum CurveType { get; }
    object SketchEntity { get; }
    bool OpposedToSketchEntity { get; }
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
}
