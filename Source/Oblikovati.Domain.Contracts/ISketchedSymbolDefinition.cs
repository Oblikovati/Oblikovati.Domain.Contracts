namespace Oblikovati.Domain.Contracts;

public interface ISketchedSymbolDefinition
{

    I_DrawingDocument Parent { get; }
    bool IsReferenced { get; }
    IDrawingSketch Sketch { get; }
    string Name { get; set; }
    IAttributeSets AttributeSets { get; }
    void Delete();
    void Edit(out IDrawingSketch Result);
    void ExitEdit(bool SaveChanges, object SaveAsName);
    ISketchedSymbolDefinition CopyTo(I_DrawingDocument TargetDocument, bool ReplaceExisting);
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    void SaveToLibrary(object TargetSketchedSymbolDefinitionLibrary, object RetainResourceFolderStructure, object DestinationFolder, object ReplaceExisting);
}
