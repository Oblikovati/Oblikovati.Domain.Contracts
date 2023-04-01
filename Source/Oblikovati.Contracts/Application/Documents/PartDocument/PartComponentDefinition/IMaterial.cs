using Oblikovati.Contracts.Application.Documents.DrawingDocument.DrawingStylesManager;
using Oblikovati.Contracts.Attributes;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition;

public interface IMaterial
{
    double Density { get; set; }
    double YoungsModulus { get; set; }
    double PoissonsRatio { get; set; }
    double YieldStrength { get; set; }
    double UltimateTensileStrength { get; set; }
    double ThermalConductivity { get; set; }
    double LinearExpansion { get; set; }
    double SpecificHeat { get; set; }
    IRenderStyle RenderStyle { get; set; }
    string Name { get; set; }
    IAttributeSets AttributeSets { get; }
    StyleLocationEnum StyleLocation { get; }
    string InternalName { get; }
    bool UpToDate { get; }
    bool InUse { get; }
    string ExternalMaterialId { get; set; }
    bool _IsIsotropicMaterial { get; }
    IMaterial Copy(string NewName);
    void Delete();
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    IMaterial ConvertToLocal();
    void SaveToGlobal();
    void UpdateFromGlobal();
}