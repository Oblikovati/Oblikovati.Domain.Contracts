﻿using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.ExtrudeFeature;
using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.PartFeature;
using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Enums;
using Oblikovati.Contracts.Sketch2D.Profiles;

namespace Oblikovati.Contracts.NotClassified;

public interface IExtrudeDefinition
{
    IObjectCollection AffectedBodies { get; set; }
    IObjectCollection AffectedOccurrences { get; set; }

    IPartFeatureExtent Extent { get; }
    IPartFeatureExtent ExtentTwo { get; }
    PartFeatureExtentEnum ExtentType { get; }
    PartFeatureExtentEnum ExtentTwoType { get; }
    bool InferiMates { get; set; }
    bool IsTwoDirectional { get; }
    bool MatchShape { get; set; }
    PartFeatureOperationEnum Operation { get; set; }
    IExtrudeFeature Parent { get; }
    IProfile Profile { get; set; }
    object TaperAngle { get; set; }
    object TaperAngleTwo { get; set; }
    IExtrudeDefinition Copy();
    void SetDistanceExtent(object Distance, PartFeatureExtentDirectionEnum ExtentDirection);
    void SetDistanceExtentTwo(object Distance);
    void SetFromToExtent(object FromFace, bool ExtendFromFace, object ToFace, bool ExtendToFace);
    void SetThroughAllExtent(PartFeatureExtentDirectionEnum ExtentDirection);
    void SetToExtent(object ToEntity, bool ExtendToFace);
    void SetToNextExtent(PartFeatureExtentDirectionEnum ExtentDirection, ISurfaceBody Terminator);

    void SetDistanceFromFaceExtent(object FromFace, bool ExtendFromFace, PartFeatureExtentDirectionEnum ExtentDirection,
        object Distance, object IsTwoDirectional, object DistanceTwo);
}