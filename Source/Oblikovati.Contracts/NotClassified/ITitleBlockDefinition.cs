using Oblikovati.Contracts.Application.Documents.DrawingDocument;
using Oblikovati.Contracts.Attributes;

namespace Oblikovati.Contracts.NotClassified;

public interface ITitleBlockDefinition
{
    IDrawingDocument Parent { get; }
    bool IsReferenced { get; }
    IDrawingSketch Sketch { get; }
    string Name { get; set; }
    IAttributeSets AttributeSets { get; }
    void Delete();
    void Edit(out IDrawingSketch Result);
    void ExitEdit(bool SaveChanges, object SaveAsName);
    ITitleBlockDefinition CopyTo(IDrawingDocument TargetDocument, bool ReplaceExisting);
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
}