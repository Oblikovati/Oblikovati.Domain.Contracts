using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application;

public interface IFileAccessEventsObject
{
    void FireOnFileResolution(string RelativeFileName, string LibraryName, ref List<byte> CustomLogicalName,
        EventTimingEnum BeforeOrAfter, INameValueMap Context, out string FullFileName,
        out HandlingCodeEnum HandlingCode);
}