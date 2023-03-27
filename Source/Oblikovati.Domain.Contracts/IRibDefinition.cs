using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IRibDefinition
{
    ISurfaceBody AffectedBody { get; set; }

    bool DirectionReversed { get; set; }
    IntPtr DraftAngle { get; set; }
    bool DraftProfileEnds { get; set; }
    bool ExtendProfile { get; set; }
    IntPtr ExtentDistance { get; }
    RibFeatureExtentEnum ExtentType { get; }
    bool IsRib { get; set; }
    IRibFeature Parent { get; }
    IObjectCollection ProfileCurves { get; set; }
    IntPtr Thickness { get; set; }
    PartFeatureExtentDirectionEnum ThicknessDirection { get; set; }
    IBossSets BossSets { get; }
    IRibDefinition Copy();
    void GetThicknessPlane(out RibThicknessPlaneEnum HoldThicknessAt, out object NeutralGeometry);
    void SetThicknessPlane(RibThicknessPlaneEnum HoldThicknessAt, object NeutralGeometry);
    void SetFiniteExtent(object Distance);
    void SetToNextExtent();
}
