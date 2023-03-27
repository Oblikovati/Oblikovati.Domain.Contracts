using Oblikovati.Domain.Contracts;
using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts.Delegates;

public delegate void FileUIEventsSink_OnFileInsertNewDialogEventHandler(string TemplateDir, List<string> FileTypes, IDocument Document, int ParentHWND, out string TemplateFileName, out string FileName, out string RelativeFileName, out string LibraryName, ref List<byte> CustomLogicalName, INameValueMap Context, out HandlingCodeEnum HandlingCode);
