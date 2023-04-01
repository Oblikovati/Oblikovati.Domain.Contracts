using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.Documents.DrawingDocument.DrawingStylesManager;

public interface ITextStyle
{
    IDrawingStylesManager _Parent { get; }

    string Name { get; set; }
    string InternalName { get; }
    bool InUse { get; }
    StyleLocationEnum StyleLocation { get; }
    bool UpToDate { get; }
    StyleTypeEnum StyleType { get; }
    string Comments { get; set; }

    string _Name { get; set; }
    bool _InUse { get; }
    string Font { get; set; }
    double FontSize { get; set; }
    bool Bold { get; set; }
    bool Italic { get; set; }
    bool Underline { get; set; }
    HorizontalTextAlignmentEnum HorizontalJustification { get; set; }
    VerticalTextAlignmentEnum VerticalJustification { get; set; }
    double WidthScale { get; set; }
    double Rotation { get; set; }
    TextLineSpacingTypeEnum LineSpacingType { get; set; }
    double LineSpacing { get; set; }
    StyleLocationEnum _StyleLocation { get; }
    string _InternalName { get; }
    bool _UpToDate { get; }
    IColor Color { get; set; }
    void Delete();
    void SaveToGlobal();
    void UpdateFromGlobal();
    IStyle ConvertToLocal();
    IStyle Copy(string Name);
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    ITextStyle _Copy(string Name);
    void _Delete();
    void GetColor(out byte Red, out byte Green, out byte Blue);
    ITextStyle _ConvertToLocal();
    void _SaveToGlobal();
    void _UpdateFromGlobal();
}