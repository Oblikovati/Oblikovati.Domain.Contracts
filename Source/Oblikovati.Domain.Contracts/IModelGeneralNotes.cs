namespace Oblikovati.Domain.Contracts;

public interface IModelGeneralNotes : IList<IModelGeneralNotes>
{
    IModelGeneralNote Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
    IModelGeneralNote Add(IModelGeneralNoteDefinition Definition);
    IModelGeneralNoteDefinition CreateDefinition(string FormattedText, bool OnScreen, object ScreenQuadrant, object AnnotationPlaneDefinition);
    IModelSurfaceTextureSymbolDefinition CreateEmbeddedSurfaceTextureSymbolDefinition();
    IModelFeatureControlFrameDefinition CreateEmbeddedFeatureControlFrameDefinition();
}
