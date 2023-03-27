using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IFileAccessEventsSink
{
    void OnFileResolution(string RelativeFileName, string LibraryName, ref List<byte> CustomLogicalName, EventTimingEnum BeforeOrAfter, INameValueMap Context, out string FullFileName, out HandlingCodeEnum HandlingCode);
    void OnFileDirty(string RelativeFileName, string LibraryName, ref List<byte> CustomLogicalName, string FullFileName, IDocument Document, EventTimingEnum BeforeOrAfter, INameValueMap Context, out HandlingCodeEnum HandlingCode);
}
