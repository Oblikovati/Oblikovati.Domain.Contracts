using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts.Delegates;

public delegate void IRxFileUIEvents_OnFileSaveAsDialogEventHandler(List<string> FileTypes, bool SaveCopyAs, int ParentHWND, out string FileName, out HandlingCodeEnum HandlingCode);
