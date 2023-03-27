using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IRenderStyle
{


    double Opacity { get; set; }
    double Reflectivity { get; set; }
    string TextureFilename { get; set; }
    double TextureScale { get; set; }
    double TextureRotation { get; set; }
    string Name { get; set; }
    IAttributeSets AttributeSets { get; }
    bool DisplayInteriorFaces { get; set; }
    string InternalName { get; }
    bool UpToDate { get; }
    StyleLocationEnum StyleLocation { get; }
    bool InUse { get; }
    string BumpMapImageFilename { get; set; }
    double BumpMapAmount { get; set; }
    double BumpMapScale { get; set; }
    double BumpMapRotation { get; set; }
    bool BumpMapInvert { get; set; }
    string RealisticAppearanceInternalName { get; set; }
    string RealisticAppearanceName { get; set; }
    double RealisticAppearanceRotation { get; set; }
    double RealisticAppearanceScale { get; set; }
    string Category { get; set; }
    string ReflectionImageFilename { get; set; }
    double Refraction { get; set; }
    void GetDiffuseColor(out byte Red, out byte Green, out byte Blue);
    void SetDiffuseColor(byte Red, byte Green, byte Blue);
    void GetSpecularColor(out byte Red, out byte Green, out byte Blue);
    void SetSpecularColor(byte Red, byte Green, byte Blue);
    void GetEmissiveColor(out byte Red, out byte Green, out byte Blue);
    void SetEmissiveColor(byte Red, byte Green, byte Blue);
    void GetAmbientColor(out byte Red, out byte Green, out byte Blue);
    void SetAmbientColor(byte Red, byte Green, byte Blue);
    IRenderStyle Copy(string NewName);
    void Delete();
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    void SaveToGlobal();
    void UpdateFromGlobal();
    IRenderStyle ConvertToLocal();
    void ApproximateFromRealisticAppearance();
    void GetProteinAsset(out object Stream);
}
