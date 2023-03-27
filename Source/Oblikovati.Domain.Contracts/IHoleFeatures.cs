using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IHoleFeatures : IList<IHoleFeatures>
{

    IHoleFeature Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
    IHoleTapInfo _CreateTapInfo(bool Metric, bool Internal, bool RightHanded, string NominalSizeDescription, string PitchDesignation, string Class, ModelDiameterFromThreadEnum DiameterInModel, bool FullTapDepth, string ThreadType, object ThreadDepth, object MajorDiameterMin, object MajorDiameterMax, object MinorDiameterMin, object MinorDiameterMax, object PitchDiameterMin, object PitchDiameterMax, object TapDrillDiameter);
    IHoleFeature AddDrilledByDistanceExtent(object PlacementDefinition, object DiameterOrTapInfo, object Depth, PartFeatureExtentDirectionEnum ExtentDirection, bool FlatBottom, object BottomTipAngle);
    IHoleFeature AddCSinkByDistanceExtent(object PlacementDefinition, object DiameterOrTapInfo, object Depth, PartFeatureExtentDirectionEnum ExtentDirection, object CSinkDiameter, object CSinkAngle, bool FlatBottom, object BottomTipAngle);
    IHoleFeature AddCBoreByDistanceExtent(object PlacementDefinition, object DiameterOrTapInfo, object Depth, PartFeatureExtentDirectionEnum ExtentDirection, object CBoreDiameter, object CBoreDepth, bool FlatBottom, object BottomTipAngle);
    IHoleFeature AddSpotFaceByDistanceExtent(object PlacementDefinition, object DiameterOrTapInfo, object Depth, PartFeatureExtentDirectionEnum ExtentDirection, object SpotFaceDiameter, object SpotFaceDepth, bool FlatBottom, object BottomTipAngle);
    IHoleFeature AddDrilledByToFaceExtent(object PlacementDefinition, object DiameterOrTapInfo, object ToFace, bool ExtendToFace, bool FlatBottom, object BottomTipAngle);
    IHoleFeature AddCSinkByToFaceExtent(object PlacementDefinition, object DiameterOrTapInfo, object ToFace, bool ExtendToFace, object CSinkDiameter, object CSinkAngle, bool FlatBottom, object BottomTipAngle);
    IHoleFeature AddCBoreByToFaceExtent(object PlacementDefinition, object DiameterOrTapInfo, object ToFace, bool ExtendToFace, object CBoreDiameter, object CBoreDepth, bool FlatBottom, object BottomTipAngle);
    IHoleFeature AddSpotFaceByToFaceExtent(object PlacementDefinition, object DiameterOrTapInfo, object ToFace, bool ExtendToFace, object SpotFaceDiameter, object SpotFaceDepth, bool FlatBottom, object BottomTipAngle);
    IHoleFeature AddDrilledByThroughAllExtent(object PlacementDefinition, object DiameterOrTapInfo, PartFeatureExtentDirectionEnum ExtentDirection);
    IHoleFeature AddCSinkByThroughAllExtent(object PlacementDefinition, object DiameterOrTapInfo, PartFeatureExtentDirectionEnum ExtentDirection, object CSinkDiameter, object CSinkAngle);
    IHoleFeature AddCBoreByThroughAllExtent(object PlacementDefinition, object DiameterOrTapInfo, PartFeatureExtentDirectionEnum ExtentDirection, object CBoreDiameter, object CBoreDepth);
    IHoleFeature AddSpotFaceByThroughAllExtent(object PlacementDefinition, object DiameterOrTapInfo, PartFeatureExtentDirectionEnum ExtentDirection, object SpotFaceDiameter, object SpotFaceDepth);
    IHoleTapInfo CreateTapInfo(bool RightHanded, string ThreadType, string ThreadDesignation, string Class, bool FullTapDepth, object ThreadDepth);
    ITaperedThreadInfo CreateTaperedTapInfo(bool RightHanded, string ThreadType, string ThreadDesignation);
    ISketchHolePlacementDefinition CreateSketchPlacementDefinition(IObjectCollection HoleCenterPoints);
    ILinearHolePlacementDefinition CreateLinearPlacementDefinition(object Plane, object ReferenceEntityOne, object DistanceOne, object ReferenceEntityTwo, object DistanceTwo, IPoint BiasPoint);
    IConcentricHolePlacementDefinition CreateConcentricPlacementDefinition(object Plane, object ConcentricReference);
    IPointHolePlacementDefinition CreatePointPlacementDefinition(object Point, object Direction);
    IHoleClearanceInfo CreateClearanceInfo(string FastenerStandard, string FastenerType, string FastenerSize, object FastenerFitType);
}
