using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IFileAccessEventsObject
{


    void FireOnFileResolution(string RelativeFileName, string LibraryName, ref List<byte> CustomLogicalName, EventTimingEnum BeforeOrAfter, INameValueMap Context, out string FullFileName, out HandlingCodeEnum HandlingCode);
}
