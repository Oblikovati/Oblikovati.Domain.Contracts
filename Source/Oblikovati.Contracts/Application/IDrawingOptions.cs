using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application;

public interface IDrawingOptions : IInjectableSingletonEntity
{
    bool DisplayLineWeights { get; set; }
    bool CenterDimensionText { get; set; }
    ArcDimensionTypeEnum ArcDimensionType { get; set; }
    CircleDimensionTypeEnum CircleDimensionType { get; set; }
    LineWeightTypeEnum LineWeightType { get; set; }
    bool GetModelDimensions { get; set; }
    LinearDimensionTypeEnum LinearDimensionType { get; set; }
    StandardPartsSectionBehaviorEnum StandardPartsSectionBehavior { get; set; }
    TitleBlockAlignmentEnum TitleBlockAlignment { get; set; }
    double UpperLimitForFirstRangeOfLineWeights { get; set; }
    double UpperLimitForSecondRangeOfLineWeights { get; set; }
    double UpperLimitForThirdRangeOfLineWeights { get; set; }
    ViewJustificationEnum ViewJustification { get; set; }
    DefaultDrawingFileTypeEnum DefaultDrawingFileType { get; set; }
    DefaultLayerStyleEnum DefaultLayerStyle { get; set; }
    DefaultNonOblikovatiDWGFileOpenBehaviorEnum DefaultNonOblikovatiDWGFileOpenBehavior { get; set; }
    DefaultObjectStyleEnum DefaultObjectStyle { get; set; }
    bool MemorySavingMode { get; set; }
    bool ShowUncutSectionViewPreview { get; set; }
    ViewPreviewTypeEnum ViewPreview { get; set; }
    bool EnableOrdinateDimGeomSelection { get; set; }
    bool EditDimensionWhenCreated { get; set; }
    DWGFileVersionEnum OblikovatiDWGFileVersion { get; set; }
    ViewBlockInsertionPointEnum ViewBlockInsertionPoint { get; set; }
    bool SkipAllUnresolvedFiles { get; set; }
    bool EnableBackgroundUpdates { get; set; }
    bool EnablePartModificationFromDrawing { get; set; }
}