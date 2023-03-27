using Oblikovati.Domain.Contracts;
using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts.Delegates;

public delegate void FileUIEventsSink_OnFileNewDialogEventHandler(string TemplateDir, int ParentHWND, out string TemplateFileName, INameValueMap Context, out HandlingCodeEnum HandlingCode);
