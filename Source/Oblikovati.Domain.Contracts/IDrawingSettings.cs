using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IDrawingSettings
{

    I_DrawingDocument Parent { get; }
    bool DeferUpdates { get; set; }
    bool HighlightInvalidAnnotations { get; set; }
    OfflineImageFidelityEnum OfflineImageFidelity { get; set; }
    DimensionTextAlignmentEnum DimensionTextAlignment { get; set; }
    bool AlwaysUseBitmapsForShadedViews { get; set; }
    bool PreserveOrphanedAnnotations { get; set; }
    IColor InvalidFeatureBasedAnnotationsColor { get; set; }
    MemorySavingModeEnum MemorySavingMode { get; set; }
    bool CrossHatchClipping { get; set; }
    string CustomPropertySourceFile { get; set; }
    IAutomatedCenterlineSettings AutomatedCenterlineSettings { get; }
}
