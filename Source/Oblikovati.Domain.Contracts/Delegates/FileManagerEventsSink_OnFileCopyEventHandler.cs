using Oblikovati.Domain.Contracts;
using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts.Delegates;

public delegate void FileManagerEventsSink_OnFileCopyEventHandler(string SourceFullFileName, string DestinationFullFileName, bool Copy, INameValueMap Context, out HandlingCodeEnum HandlingCode);
