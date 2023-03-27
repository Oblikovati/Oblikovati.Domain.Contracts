using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts.Delegates;

public delegate void FileAccessEventsSink_OnFileResolutionEventHandler(string RelativeFileName, string LibraryName, ref List<byte> CustomLogicalName, EventTimingEnum BeforeOrAfter, INameValueMap Context, out string FullFileName, out HandlingCodeEnum HandlingCode);
