using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IFileUIEventsSink
{
    void OnFileNewDialog(string TemplateDir, int ParentHWND, out string TemplateFileName, INameValueMap Context, out HandlingCodeEnum HandlingCode);
    void OnFileOpenDialog(List<string> FileTypes, int ParentHWND, out string FileName, INameValueMap Context, out HandlingCodeEnum HandlingCode);
    void OnFileSaveAsDialog(List<string> FileTypes, bool SaveCopyAs, int ParentHWND, out string FileName, INameValueMap Context, out HandlingCodeEnum HandlingCode);
    void OnFileInsertNewDialog(string TemplateDir, List<string> FileTypes, IDocument Document, int ParentHWND, out string TemplateFileName, out string FileName, out string RelativeFileName, out string LibraryName, ref List<byte> CustomLogicalName, INameValueMap Context, out HandlingCodeEnum HandlingCode);
    void OnFileInsertDialog(List<string> FileTypes, IDocument Document, int ParentHWND, out string FileName, out string RelativeFileName, out string LibraryName, ref List<byte> CustomLogicalName, INameValueMap Context, out HandlingCodeEnum HandlingCode);
    void OnFileOpenFromMRU(ref string FullFileName, INameValueMap Context, out HandlingCodeEnum HandlingCode);
    void OnFileNew(DocumentTypeEnum DocumentType, ref string TemplateFileName, INameValueMap Context, out HandlingCodeEnum HandlingCode);
    void OnPopulateFileMetadata(IObjectsEnumerator FileMetadataObjects, string Formulae, INameValueMap Context, out HandlingCodeEnum HandlingCode);
}
