using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application;

public interface IPartOptions : IInjectableSingletonEntity
{
    bool AutoHideInLineWorkFeatures { get; set; }
    bool OpaqueConstructionSurfaces { get; set; }
    SketchCreationOnNewPartEnum SketchCreationOnNewPart { get; set; }
    DimensionConstraintsRelaxationEnum DimensionConstraintsRelaxation { get; set; }
    GeometricConstraintsBreakageEnum GeometricConstraintsBreakage { get; set; }
    bool AutoConsumeWorkAndSurfaceFeatures { get; set; }
    bool Enable3DGrips { get; set; }
    bool DisplayGripsOnSelection { get; set; }
    bool EditBaseSolidsUsingFusion { get; set; }
    bool SkipAllUnresolvedFiles { get; set; }
    DesignViewTypeEnum DefaultDesignView { get; set; }
    bool DefaultDesignViewIsAssociative { get; set; }
    bool DisplayExtendedName { get; set; }
    bool EnableConstructionEnvironment { get; set; }
    bool DerivedPartColorOverride { get; set; }
}