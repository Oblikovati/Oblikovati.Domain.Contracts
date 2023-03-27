using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IProfileEntity
{

    IProfilePath Parent { get; }
    object Curve { get; }
    Curve2dTypeEnum CurveType { get; }
    ISketchEntity SketchEntity { get; }
    ISketchPoint StartSketchPoint { get; }
    ISketchPoint EndSketchPoint { get; }
    bool OpposedToSketchEntity { get; }
    IAttributeSets AttributeSets { get; }
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
}
