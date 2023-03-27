using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts.Delegates;

public delegate void FileManagerEventsSink_OnFileDeleteEventHandler(string FullFileName, INameValueMap Context, out HandlingCodeEnum HandlingCode);
