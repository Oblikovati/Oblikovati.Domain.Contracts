using Oblikovati.Domain.Contracts;
using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts.Delegates;

public delegate void IRxFileUIEvents_OnFileInsertDialogEventHandler(List<string> FileTypes, IDocument Document, int ParentHWND, out string FileName, out string RelativeFileName, out string LibraryName, out List<byte> CustomLogicalName, out HandlingCodeEnum HandlingCode);
