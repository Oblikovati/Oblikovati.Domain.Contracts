using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts.Delegates;

public delegate void FileUIEventsSink_OnFileSaveAsDialogEventHandler(List<string> FileTypes, bool SaveCopyAs, int ParentHWND, out string FileName, INameValueMap Context, out HandlingCodeEnum HandlingCode);
