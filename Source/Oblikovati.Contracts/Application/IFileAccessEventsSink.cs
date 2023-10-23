using Oblikovati.Contracts.Application.Documents.Document;
using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application;

public interface IFileAccessEventsSink
{
    void OnFileResolution(string RelativeFileName, string LibraryName, ref List<byte> CustomLogicalName,
        EventTiming BeforeOrAfter, INameValueMap Context, out string FullFileName,
        out HandlingCodeEnum HandlingCode);

    void OnFileDirty(string RelativeFileName, string LibraryName, ref List<byte> CustomLogicalName, string FullFileName,
        IDocument Document, EventTiming BeforeOrAfter, INameValueMap Context, out HandlingCodeEnum HandlingCode);
}