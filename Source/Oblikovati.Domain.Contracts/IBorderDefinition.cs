namespace Oblikovati.Domain.Contracts;

public interface IBorderDefinition
{

    I_DrawingDocument Parent { get; }
    bool IsReferenced { get; }
    IDrawingSketch Sketch { get; }
    string Name { get; set; }
    bool IsDefault { get; }
    IAttributeSets AttributeSets { get; }
    void Delete();
    void Edit(out IDrawingSketch Sketch);
    void ExitEdit(bool SaveChanges, object SaveAsName);
    IBorderDefinition CopyTo(I_DrawingDocument TargetDocument, bool ReplaceExisting);
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
}
