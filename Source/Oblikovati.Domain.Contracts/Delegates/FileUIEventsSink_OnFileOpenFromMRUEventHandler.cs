using Oblikovati.Domain.Contracts;
using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts.Delegates;

public delegate void FileUIEventsSink_OnFileOpenFromMRUEventHandler(ref string FullFileName, INameValueMap Context, out HandlingCodeEnum HandlingCode);
