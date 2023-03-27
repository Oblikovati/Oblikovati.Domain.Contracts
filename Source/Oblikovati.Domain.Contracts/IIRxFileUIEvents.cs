using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IIRxFileUIEvents
{
    void OnFileNewDialog(string TemplateDir, int ParentHWND, out string TemplateFileName, out HandlingCodeEnum HandlingCode);
    void OnFileOpenDialog(List<string> FileTypes, int ParentHWND, out string FileName, out HandlingCodeEnum HandlingCode);
    void OnFileSaveAsDialog(List<string> FileTypes, bool SaveCopyAs, int ParentHWND, out string FileName, out HandlingCodeEnum HandlingCode);
    void OnFileInsertNewDialog(string TemplateDir, List<string> FileTypes, IDocument Document, int ParentHWND, out string TemplateFileName, out string FileName, out string RelativeFileName, out string LibraryName, out List<byte> CustomLogicalName, out HandlingCodeEnum HandlingCode);
    void OnFileInsertDialog(List<string> FileTypes, IDocument Document, int ParentHWND, out string FileName, out string RelativeFileName, out string LibraryName, out List<byte> CustomLogicalName, out HandlingCodeEnum HandlingCode);
}
