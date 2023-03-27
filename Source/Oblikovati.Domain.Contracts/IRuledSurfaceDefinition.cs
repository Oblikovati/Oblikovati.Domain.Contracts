using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IRuledSurfaceDefinition
{

    RuledSurfaceTypeEnum RuledSurfaceType { get; }
    object Distance { get; set; }
    object DraftAngle { get; set; }
    object GeneratrixCurves { get; set; }
    bool FlipExtendDirection { get; set; }
    IRuledSurfaceFeature Parent { get; }
    object Vector { get; set; }
    IRuledSurfaceDefinition Copy();
    void SetToNormal(IRuledSurfaceEdgeFacePairs GeneratrixCurves, object Distance, bool FlipExtendDirection);
    void SetToTangent(IRuledSurfaceEdgeFacePairs GeneratrixCurves, object Distance, bool FlipExtendDirection);
    void SetToSweep(object GeneratrixCurves, object Distance, object Vector, bool FlipExtendDirection);
}
