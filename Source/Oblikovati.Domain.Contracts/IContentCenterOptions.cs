using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IContentCenterOptions
{

    bool RefreshOutOfDateStandardParts { get; set; }
    bool CustomFamilyAsStandard { get; set; }
    bool CheckFamiliesUpdates { get; set; }
    ContentCenterDecimalMarkerOptionEnum FilenameDecimalMarker { get; }
    void GetAccessOption(out ContentCenterAccessOptionEnum AccessOption, out string LibrariesLocation);
    void SetAccessOption(ContentCenterAccessOptionEnum AccessOption, string LibrariesLocation);
}
