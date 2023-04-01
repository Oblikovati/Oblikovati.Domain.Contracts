using Oblikovati.Contracts.Application.Documents.DrawingDocument;
using Oblikovati.Contracts.Attributes;

namespace Oblikovati.Contracts.DWG;

public interface IAutoCADBlockDefinition
{
    IAttributeSets AttributeSets { get; }
    bool IsReferenced { get; }
    string Name { get; }
    IDrawingDocument Parent { get; }
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    IAutoCADBlockDefinition CopyTo(IDrawingDocument TargetDocument, bool ReplaceExisting);
    void Delete();
    void GetPromptTags(out object Tags, out object Prompts);
}