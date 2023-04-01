using Oblikovati.Contracts.Attributes;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.LightingStyles;

public interface ILightingStyle
{
    string Name { get; set; }
    string InternalName { get; }
    double Ambience { get; set; }
    double Brightness { get; set; }
    int Exposure { get; set; }
    ILights Lights { get; }
    bool InUse { get; }
    bool UpToDate { get; }
    StyleLocationEnum StyleLocation { get; }
    double AmbientShadowIntensity { get; set; }
    IAttributeSets AttributeSets { get; }
    double ImageBasedLightingBrightness { get; set; }
    double ImageBasedLightingRotation { get; set; }
    double ImageBasedLightingScale { get; set; }
    bool ImageBasedLightingShowImage { get; set; }
    string ImageBasedLightingSourceInternalName { get; set; }
    string ImageBasedLightingSourceName { get; set; }
    double ShadowDensity { get; set; }
    ShadowDirectionEnum ShadowDirection { get; set; }
    double ShadowSoftness { get; set; }
    void SaveToGlobal();
    void UpdateFromGlobal();
    ILightingStyle ConvertToLocal();
    ILightingStyle Copy(string NewName);
    void Delete();
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
}