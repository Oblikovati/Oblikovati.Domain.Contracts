using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Enums;
using Oblikovati.Contracts.NotClassified;

namespace Oblikovati.Contracts.Application.Documents.DrawingDocument;

public interface IDrawingSettings
{
    IDrawingDocument Parent { get; }
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