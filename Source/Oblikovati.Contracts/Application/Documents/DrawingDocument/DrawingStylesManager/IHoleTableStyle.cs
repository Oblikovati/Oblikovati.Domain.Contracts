using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.Documents.DrawingDocument.DrawingStylesManager;

public interface IHoleTableStyle
{
    IDrawingStylesManager _Parent { get; }

    string Name { get; set; }
    string InternalName { get; }
    bool InUse { get; }
    StyleLocationEnum StyleLocation { get; }
    bool UpToDate { get; }
    StyleTypeEnum StyleType { get; }
    string Comments { get; set; }

    string Title { get; set; }
    HeadingPlacementEnum HeadingPlacement { get; set; }
    ITextStyle TitleTextStyle { get; set; }
    ITextStyle ColumnHeaderTextStyle { get; set; }
    ITextStyle DataTextStyle { get; set; }
    IColor InsideLineColor { get; set; }
    double InsideLineWeight { get; set; }
    IColor OutsideLineColor { get; set; }
    double OutsideLineWeight { get; set; }
    bool PreserveTagging { get; set; }
    bool UseLeaderForTags { get; set; }
    bool GroupHoleTypes { get; set; }
    bool ArrangeByPosition { get; set; }
    RowMergeTypeEnum RowMergeType { get; set; }
    bool ReformatOnCustomHoleMatch { get; set; }
    bool SequentialNumbering { get; set; }
    bool DeleteTagsOnRollup { get; set; }
    bool SecondaryTagModifierOnRollup { get; set; }
    bool IncludeHoleFeatures { get; set; }
    bool IncludeCircularCuts { get; set; }
    bool IncludeCentermarks { get; set; }
    bool IncludeRecoveredPunchCenters { get; set; }
    bool IncludeDrilledHoleFeatures { get; set; }
    bool IncludeCounterBoreHoleFeatures { get; set; }
    bool IncludeCounterSinkHoleFeatures { get; set; }
    bool IncludeThreadedHoleFeatures { get; set; }
    void Delete();
    void SaveToGlobal();
    void UpdateFromGlobal();
    IStyle ConvertToLocal();
    IStyle Copy(string Name);
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);

    void AddColumn(HolePropertyEnum PropertyType, string CustomPropertyName, string Title, double Width,
        HorizontalTextAlignmentEnum TitleHorizontalJustification,
        HorizontalTextAlignmentEnum ValueHorizontalJustification);

    void RemoveAllColumns();
}