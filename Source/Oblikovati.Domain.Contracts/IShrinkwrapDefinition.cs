using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IShrinkwrapDefinition
{

    string ActiveDesignViewRepresentation { get; set; }
    bool IsAssociativeDesignView { get; set; }
    string ActiveLevelOfDetailRepresentation { get; set; }
    string ActivePositionalRepresentation { get; set; }
    IObjectCollection AdditionalIncludedOccurrences { get; set; }
    IObjectCollection AdditionalExcludedOccurrences { get; set; }
    bool BreakLink { get; set; }
    bool CreateIndependentBodiesOnFailedBoolean { get; set; }
    DerivedComponentStyleEnum DeriveStyle { get; set; }
    bool UseColorOverrideFromSourceComponent { get; set; }
    string FullFileName { get; }
    bool RemoveAllInternalVoids { get; set; }
    bool RenameComponent { get; set; }
    bool RemovePartsByVisibility { get; }
    double RemovePartsVisibilityRatio { get; }
    bool RemovePartsBySize { get; set; }
    double RemovePartsSize { get; set; }
    ShrinkwrapRemoveStyleEnum RemoveHolesStyle { get; set; }
    double RemoveHolesDiameterRange { get; set; }
    ShrinkwrapRemoveStyleEnum RemoveChamfersStyle { get; set; }
    double RemoveChamfersDistanceRange { get; set; }
    ShrinkwrapRemoveStyleEnum RemoveFilletsStyle { get; set; }
    double RemoveFilletsRadiusRange { get; set; }
    ShrinkwrapRemoveStyleEnum RemovePocketsStyle { get; set; }
    double RemovePocketsMaxFaceLoopRange { get; set; }
    IShrinkwrapComponent Parent { get; }
    IObjectCollection PreservedFeatures { get; set; }
    bool RemoveInternalParts { get; set; }
    double RemovePocketsMaxDepthRange { get; set; }
    double RemoveEmbossMaxHeightRange { get; set; }
    ShrinkwrapRemoveStyleEnum RemoveEmbossStyle { get; set; }
    ShrinkwrapRemoveStyleEnum RemoveTunnelsStyle { get; set; }
    EnvelopesReplaceStyleEnum EnvelopesReplaceStyle { get; set; }
    string ActiveModelState { get; set; }
    IShrinkwrapDefinition Copy();
}
