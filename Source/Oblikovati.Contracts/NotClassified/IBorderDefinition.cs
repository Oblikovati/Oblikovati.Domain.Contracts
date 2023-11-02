using Oblikovati.Contracts.Application.Documents.DrawingDocument;
using Oblikovati.Contracts.Attributes;

namespace Oblikovati.Contracts.NotClassified;

public interface IBorderDefinition
{
    IDrawingDocument Parent { get; }
    bool IsReferenced { get; }
    IDrawingSketch Sketch { get; }
    string Name { get; set; }
    bool IsDefault { get; }
    IAttributeSets AttributeSets { get; }
    void Delete();
    void Edit(out IDrawingSketch Sketch);
    void ExitEdit(bool SaveChanges, object SaveAsName);
    IBorderDefinition CopyTo(IDrawingDocument TargetDocument, bool ReplaceExisting);
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
}