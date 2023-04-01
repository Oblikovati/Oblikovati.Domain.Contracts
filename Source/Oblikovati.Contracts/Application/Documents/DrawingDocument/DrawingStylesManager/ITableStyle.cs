using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.Documents.DrawingDocument.DrawingStylesManager;

public interface ITableStyle
{
    IDrawingStylesManager _Parent { get; }

    string Name { get; set; }
    string InternalName { get; }
    bool InUse { get; }
    StyleLocationEnum StyleLocation { get; }
    bool UpToDate { get; }
    StyleTypeEnum StyleType { get; }
    string Comments { get; set; }

    ITextStyle ColumnHeaderTextStyle { get; set; }
    HorizontalTextAlignmentEnum ColumnTitleHorizontalJustification { get; set; }
    HorizontalTextAlignmentEnum ColumnValueHorizontalJustification { get; set; }
    double ColumnWidth { get; set; }
    ITextStyle DataTextStyle { get; set; }
    double HeadingGap { get; set; }
    HeadingPlacementEnum HeadingPlacement { get; set; }
    IColor InsideLineColor { get; set; }
    double InsideLineWeight { get; set; }
    IColor OutsideLineColor { get; set; }
    double OutsideLineWeight { get; set; }
    double RowGap { get; set; }
    LineSpacingEnum RowLineSpacing { get; set; }
    bool ShowTitle { get; set; }
    TableDirectionEnum TableDirection { get; set; }
    string Title { get; set; }
    ITextStyle TitleTextStyle { get; set; }
    void Delete();
    void SaveToGlobal();
    void UpdateFromGlobal();
    IStyle ConvertToLocal();
    IStyle Copy(string Name);
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);

    void AddColumn(string Title, double Width, HorizontalTextAlignmentEnum TitleHorizontalJustification,
        HorizontalTextAlignmentEnum ValueHorizontalJustification);

    void RemoveAllColumns();
}