using Oblikovati.Domain.Contracts;
using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts.Delegates;

public delegate void FileAccessEventsSink_OnFileDirtyEventHandler(string RelativeFileName, string LibraryName, ref List<byte> CustomLogicalName, string FullFileName, IDocument Document, EventTimingEnum BeforeOrAfter, INameValueMap Context, out HandlingCodeEnum HandlingCode);
