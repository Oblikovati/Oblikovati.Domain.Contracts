using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.ContentCenter;

public interface IContentCenterOptions
{
    bool RefreshOutOfDateStandardParts { get; set; }
    bool CustomFamilyAsStandard { get; set; }
    bool CheckFamiliesUpdates { get; set; }
    ContentCenterDecimalMarkerOptionEnum FilenameDecimalMarker { get; }
    void GetAccessOption(out ContentCenterAccessOptionEnum AccessOption, out string LibrariesLocation);
    void SetAccessOption(ContentCenterAccessOptionEnum AccessOption, string LibrariesLocation);
}