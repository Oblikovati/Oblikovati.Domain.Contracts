namespace Oblikovati.Contracts.Application.Documents.DrawingDocument.DrawingStylesManager;

public interface IStylesManager
{
    IMaterialsEnumerator Materials { get; }
    void GetStyleNameFromKey(ref List<byte> ReferenceKey, out string InternalName, out string DisplayName);
}