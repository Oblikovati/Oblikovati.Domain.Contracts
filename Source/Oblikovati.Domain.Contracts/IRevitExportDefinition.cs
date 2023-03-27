using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IRevitExportDefinition
{
    IRevitExport Parent { get; }
    string ActiveModelState { get; set; }
    string ActiveDesignViewRepresentation { get; set; }
    bool IsAssociativeDesignView { get; set; }
    string ActivePositionalRepresentation { get; set; }
    EnvelopesReplaceStyleEnum EnvelopesReplaceStyle { get; set; }
    bool RemovePartsBySize { get; set; }
    double RemovePartsSize { get; set; }
    IObjectCollection AdditionalIncludedOccurrences { get; set; }
    IObjectCollection AdditionalExcludedOccurrences { get; set; }
    SimplificationRemoveStyleEnum RemoveHolesStyle { get; set; }
    double RemoveHolesDiameterRange { get; set; }
    SimplificationRemoveStyleEnum RemoveFilletsStyle { get; set; }
    double RemoveFilletsRadiusRange { get; set; }
    SimplificationRemoveStyleEnum RemoveChamfersStyle { get; set; }
    double RemoveChamfersDistanceRange { get; set; }
    SimplificationRemoveStyleEnum RemovePocketsStyle { get; set; }
    double RemovePocketsMaxDepthRange { get; set; }
    SimplificationRemoveStyleEnum RemoveEmbossStyle { get; set; }
    double RemoveEmbossMaxHeightRange { get; set; }
    SimplificationRemoveStyleEnum RemoveTunnelsStyle { get; set; }
    IObjectCollection PreservedFeatures { get; set; }
    string FileName { get; set; }
    string Location { get; set; }
    RevitExportStructureTypeEnum Structure { get; set; }
    bool EnableUpdating { get; set; }
    bool RemoveAllInternalVoids { get; set; }
    bool RemoveInternalParts { get; set; }
    bool UseColorOverrideFromSourceComponent { get; set; }
    IRevitExportDefinition Copy();
}
