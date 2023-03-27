using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts.Delegates;

public delegate void IRxFileAccessEvents_OnFileResolutionEventHandler(string RelativeFileName, string LibraryName, List<byte> CustomLogicalName, out string FullFileName, out HandlingCodeEnum HandlingCode);
