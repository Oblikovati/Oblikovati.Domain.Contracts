using Oblikovati.Domain.Contracts;
using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts.Delegates;

public delegate void FileDialogEventsSink_OnOptionsEventHandler(INameValueMap Context, out HandlingCodeEnum HandlingCode);
