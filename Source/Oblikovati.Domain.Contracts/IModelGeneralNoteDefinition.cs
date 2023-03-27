namespace Oblikovati.Domain.Contracts;

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
