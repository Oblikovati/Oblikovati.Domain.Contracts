using Oblikovati.Contracts.Application.Documents.DrawingDocument.DrawingStylesManager;
using Oblikovati.Contracts.Application.Documents.PartDocument.SheetMetalComponentDefinition;
using Oblikovati.Contracts.Application.TransientGeometry;
using Oblikovati.Contracts.Application.TransientObjects.Math;
using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Attributes;
using Oblikovati.Contracts.ClientGraphics.DrawingView;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts;

public interface IHoleTable
{
    ISheet Parent { get; }
    IAttributeSets AttributeSets { get; }
    string Title { get; set; }
    HeadingPlacementEnum HeadingPlacement { get; set; }
    IPoint2d Position { get; set; }
    IHoleTableColumns HoleTableColumns { get; }
    IHoleTableRows HoleTableRows { get; }
    ILayer Layer { get; set; }
    HoleTableTypeEnum HoleTableType { get; }
    IDrawingView ParentView { get; }
    IHoleTableStyle Style { get; set; }
    ITextStyle TitleTextStyle { get; set; }
    ITextStyle ColumnHeaderTextStyle { get; set; }
    ITextStyle DataTextStyle { get; set; }
    bool PreserveTagging { get; set; }
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
    IBox2d RangeBox { get; }
    bool ShowTitle { get; set; }
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    void Delete();
    void ShowTags(bool Value);
    void MatchCustomHoles(IObjectCollection HoleTags);
    void Export(string FileName, FileFormatEnum FileFormat, object Options);
}