using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts.Delegates;

public delegate void IRxFileUIEvents_OnFileNewDialogEventHandler(string TemplateDir, int ParentHWND, out string TemplateFileName, out HandlingCodeEnum HandlingCode);
