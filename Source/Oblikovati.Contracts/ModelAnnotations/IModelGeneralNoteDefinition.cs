using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition;
using Oblikovati.Contracts.Application.TransientGeometry;
using Oblikovati.Contracts.NotClassified;

namespace Oblikovati.Contracts.ModelAnnotations;

public interface IModelGeneralNoteDefinition
{
    IModelAnnotation Parent { get; }
    IAnnotationPlane AnnotationPlane { get; set; }
    IAnnotationPlaneDefinition AnnotationPlaneDefinition { get; set; }
    IGeometryIntent Intent { get; set; }
    IPoint Position { get; set; }
    IModelAnnotationText Text { get; }
    IGeneralNoteSymbolDefinitions SymbolDefinitions { get; }
    bool OnScreen { get; }
    IntPtr ScreenQuadrant { get; set; }
    IModelGeneralNoteDefinition Copy();
    void SetToOnScreenDisplay(object ScreenQuadrant);
    void SetToModelSpaceDisplay(IAnnotationPlaneDefinition AnnotationPlaneDefinition, object Intent, object Position);
}