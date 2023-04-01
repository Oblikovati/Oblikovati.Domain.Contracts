using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.ReferenceComponents.
    DerivedAssemblyComponents;

public interface IDerivedAssemblyDefinition
{
    IDerivedAssemblyOccurrences Occurrences { get; }
    DerivedComponentOptionEnum InclusionOption { get; set; }

    string ActivePositionalRepresentation { get; set; }
    string ActiveDesignViewRepresentation { get; set; }
    string ActiveLevelOfDetailRepresentation { get; set; }
    bool IsAssociativeDesignView { get; set; }
    double ScaleFactor { get; set; }
    DerivedPartMirrorPlaneEnum MirrorPlane { get; set; }
    bool ReducedMemoryMode { get; set; }
    DerivedComponentStyleEnum DeriveStyle { get; set; }
    bool KeepSeams { get; set; }
    DerivedComponentOptionEnum IncludeAllTopLeveliMateDefinitions { get; set; }
    DerivedComponentOptionEnum IncludeAllTopLevelParameters { get; set; }
    DerivedComponentOptionEnum IncludeAllTopLevelSketches { get; set; }
    DerivedComponentOptionEnum IncludeAllTopLevelWorkFeatures { get; set; }
    bool IndependentSolidsOnFailedBoolean { get; set; }
    bool RemoveInternalVoids { get; set; }
    bool UseColorOverridesFromSource { get; set; }
    string ActiveModelState { get; set; }

    void GetHolePatchingOptions(out DerivedHolePatchEnum HolePatchType, out double MinimumPerimeter,
        out double MaximumPerimeter, out IEdgeCollection Reserved);

    void GetRemoveBySizeOptions(out bool Enable, out int SizeRatioPercentage);

    void GetRemoveByVisibilityOptions(out DerivedGeometryRemovalEnum GeometryToRemove, out int VisibilityPercentage,
        out bool IgnoreSurfaceFeatures);

    void SetHolePatchingOptions(DerivedHolePatchEnum HolePatchType, double MinimumPerimeter, double MaximumPerimeter,
        object Reserved);

    void SetRemoveBySizeOptions(bool Enable, int SizeRatioPercentage);

    void SetRemoveByVisibilityOptions(DerivedGeometryRemovalEnum GeometryToRemove, int VisibilityPercentage,
        bool IgnoreSurfaceFeatures);

    void IncludeAllSketches();
    void IncludeAllWorkFeatures();
    void IncludeAllParameters();
}