namespace Oblikovati.Domain.Contracts;

public interface IAutoCADBlockDefinition
{

    IAttributeSets AttributeSets { get; }
    bool IsReferenced { get; }
    string Name { get; }
    I_DrawingDocument Parent { get; }
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    IAutoCADBlockDefinition CopyTo(I_DrawingDocument TargetDocument, bool ReplaceExisting);
    void Delete();
    void GetPromptTags(out object Tags, out object Prompts);
}
