using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IDrawingStandardStyle
{
    IDrawingStylesManager _Parent { get; }

    string Name { get; set; }
    string InternalName { get; }
    bool InUse { get; }
    StyleLocationEnum StyleLocation { get; }
    bool UpToDate { get; }
    StyleTypeEnum StyleType { get; }
    string Comments { get; set; }

    IObjectDefaultsStyle ActiveObjectDefaults { get; set; }
    bool _InUse { get; }
    StyleLocationEnum _StyleLocation { get; }
    string _Name { get; set; }
    string _InternalName { get; }
    bool _UpToDate { get; }
    bool ApplyExcludeCharactersToBendTables { get; set; }
    bool ApplyExcludeCharactersToHoleTables { get; set; }
    bool ApplyExcludeCharactersToRevisionTables { get; set; }
    bool ApplyExcludeCharactersToViewNames { get; set; }
    DecimalMarkerTypeEnum DecimalMarkerType { get; set; }
    string ExcludeCharacters { get; set; }
    bool FirstAngleProjection { get; set; }
    FrontViewPlaneEnum FrontViewPlane { get; set; }
    double GlobalLineScale { get; set; }
    DraftingStandardEnum InternationalStandardReference { get; }
    UnitsTypeEnum LinearUnits { get; set; }
    bool PartialSectionThreadEnd { get; set; }
    bool PartialCircularThreadEdge { get; set; }
    object PresetLineWeights { get; set; }
    object PresetScales { get; set; }
    object PresetTextHeights { get; set; }
    object PresetSectionHatchAngles { get; set; }
    void Delete();
    void SaveToGlobal();
    void UpdateFromGlobal();
    IStyle ConvertToLocal();
    IStyle Copy(string Name);
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    IDrawingStandardStyle _Copy(string Name);
    IDrawingStandardStyle _ConvertToLocal();
    void _SaveToGlobal();
    void _UpdateFromGlobal();
    void _Delete();
    void GetViewLabelDefaults(DrawingViewTypeEnum ViewType, out string Prefix, out bool Visible, out string FormattedText, out bool ConstrainToBorder, out bool PlaceBelowView);
    void SetViewLabelDefaults(DrawingViewTypeEnum ViewType, string Prefix, bool Visible, string FormattedText, bool ConstrainToBorder, bool PlaceBelowView);
}
