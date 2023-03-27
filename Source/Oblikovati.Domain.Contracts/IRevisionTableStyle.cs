using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IRevisionTableStyle
{
    IDrawingStylesManager _Parent { get; }

    string Name { get; set; }
    string InternalName { get; }
    bool InUse { get; }
    StyleLocationEnum StyleLocation { get; }
    bool UpToDate { get; }
    StyleTypeEnum StyleType { get; }
    string Comments { get; set; }

    bool AllowLandingLineForRevisionTags { get; set; }
    ITextStyle ColumnHeaderTextStyle { get; set; }
    ITextStyle DataTextStyle { get; set; }
    double HeadingGap { get; set; }
    HeadingPlacementEnum HeadingPlacement { get; set; }
    IColor InsideLineColor { get; set; }
    double InsideLineWeight { get; set; }
    IColor OutsideLineColor { get; set; }
    double OutsideLineWeight { get; set; }
    ILeaderStyle RevisionTagLeaderStyle { get; set; }
    RevisionTagShapeEnum RevisionTagShape { get; set; }
    ITextStyle RevisionTagTextStyle { get; set; }
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
    void AddColumn(RevisionTablePropertyEnum PropertyType, string PropertySetId, object PropertyIdentifier, string Title, double Width, HorizontalTextAlignmentEnum TitleHorizontalJustification, HorizontalTextAlignmentEnum ValueHorizontalJustification);
    void RemoveAllColumns();
}
