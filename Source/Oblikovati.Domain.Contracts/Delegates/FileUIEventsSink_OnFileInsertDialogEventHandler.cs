using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts.Delegates;

public delegate void FileUIEventsSink_OnFileInsertDialogEventHandler(List<string> FileTypes, IDocument Document, int ParentHWND, out string FileName, out string RelativeFileName, out string LibraryName, ref List<byte> CustomLogicalName, INameValueMap Context, out HandlingCodeEnum HandlingCode);
