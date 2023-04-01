namespace Oblikovati.Contracts.ModelAnnotations;

public interface IModelGeneralNotes : IList<IModelGeneralNotes>
{
    IModelGeneralNote Item { get; }


    IModelGeneralNote Add(IModelGeneralNoteDefinition Definition);

    IModelGeneralNoteDefinition CreateDefinition(string FormattedText, bool OnScreen, object ScreenQuadrant,
        object AnnotationPlaneDefinition);

    IModelSurfaceTextureSymbolDefinition CreateEmbeddedSurfaceTextureSymbolDefinition();
    IModelFeatureControlFrameDefinition CreateEmbeddedFeatureControlFrameDefinition();
}