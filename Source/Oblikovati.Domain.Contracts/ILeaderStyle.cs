using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface ILeaderStyle
{
    IDrawingStylesManager _Parent { get; }

    string Name { get; set; }
    string InternalName { get; }
    bool InUse { get; }
    StyleLocationEnum StyleLocation { get; }
    bool UpToDate { get; }
    StyleTypeEnum StyleType { get; }
    string Comments { get; set; }

    ArrowheadTypeEnum ArrowheadType { get; set; }
    double ArrowheadSize { get; set; }
    double ArrowheadHeight { get; set; }
    IColor OverrideColor { get; set; }
    IColor Color { get; set; }
    double LineWeight { get; set; }
    LineTypeEnum LineType { get; set; }
    double ExtensionLineOffset { get; set; }
    double ExtensionLineOvershoot { get; set; }
    bool ScaleToTextHeight { get; set; }
    double AllAroundSymbolDiameter { get; set; }
    void Delete();
    void SaveToGlobal();
    void UpdateFromGlobal();
    IStyle ConvertToLocal();
    IStyle Copy(string Name);
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    void GetCustomLineType(out string LineTypeName, out string LineTypeDescription);
    void SetCustomLineType(string FullFileName, string LineTypeName, bool ReplaceExisting);
}
