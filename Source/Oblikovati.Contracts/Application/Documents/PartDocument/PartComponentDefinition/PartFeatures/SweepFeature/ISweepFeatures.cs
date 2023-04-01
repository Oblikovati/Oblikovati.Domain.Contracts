using Oblikovati.Contracts.Application.TransientGeometry;
using Oblikovati.Contracts.Application.TransientObjects.Math;
using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Enums;
using Oblikovati.Contracts.Sketch2D.Profiles;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.SweepFeature;

public interface ISweepFeatures : IList<ISweepFeatures>
{
    ISweepFeature Item { get; }


    IPath CreatePath(object SketchCurve);
    ISweepFeature _Add(IProfile Profile, IPath Path, PartFeatureOperationEnum Operation, object TaperAngle);

    ISweepFeature AddUsingPath(IProfile Profile, IPath SweepPath, PartFeatureOperationEnum Operation,
        SweepProfileOrientationEnum ProfileOrientation, object TaperAngle);

    ISweepFeature AddUsingPathAndGuideRail(IProfile Profile, IPath SweepPath, IPath GuideRail,
        PartFeatureOperationEnum Operation, SweepProfileScalingEnum ProfileScaling);

    ISweepFeature AddUsingPathAndGuideSurface(IProfile Profile, IPath SweepPath, object GuideSurface,
        PartFeatureOperationEnum Operation);

    ISweepFeature AddUsingPathAndSectionTwists(IProfile Profile, IPath SweepPath, PartFeatureOperationEnum Operation,
        IObjectCollection SectionTwistPoints, IObjectCollection SectionTwistVectors,
        SweepProfileOrientationEnum ProfileOrientation, object TaperAngle);

    IObjectsEnumerator GetProfileOrientationAtParam(object PathCurve, IUnitVector StartProfileOrientation,
        IUnitVector StartProfileNormal, List<double> Params);

    object GetTruePath(object PathCurves, IPoint TrueStartPoint);

    ISweepDefinition CreateSweepDefinition(SweepTypeEnum SweepType, IProfile Profile, IPath Path,
        PartFeatureOperationEnum Operation);

    ISolidSweepDefinition CreateSolidSweepDefinition(ISurfaceBody ToolBody, IPath Path,
        PartFeatureOperationEnum Operation, IObjectCollection AffectedBodies, bool KeepToolbody);

    ISweepFeature Add(ISweepDefinition Definition);
    ISweepFeature AddSolidSweep(ISolidSweepDefinition Definition);
}