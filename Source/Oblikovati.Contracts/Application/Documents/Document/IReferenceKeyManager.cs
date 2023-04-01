namespace Oblikovati.Contracts.Application.Documents.Document;

public interface IReferenceKeyManager
{
    object BindKeyToObject(ref List<byte> ReferenceKey, int KeyContext, out object MatchType);
    int CreateKeyContext();
    void SaveContextToArray(int KeyContext, ref List<byte> Result);
    int LoadContextFromArray(ref List<byte> ContextData);
    void StringToKey(string ReferenceKeyString, ref List<byte> ReferenceKey);
    bool CanBindKeyToObject(ref List<byte> ReferenceKey, int KeyContext, out object Context);
    void ReleaseKeyContext(int KeyContext);
}