using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IPunchNote
{

    ISheet Parent { get; }
    IAttributeSets AttributeSets { get; }
    IColor Color { get; set; }
    string Text { get; set; }
    string FormattedText { get; set; }
    HorizontalTextAlignmentEnum HorizontalJustification { get; set; }
    VerticalTextAlignmentEnum VerticalJustification { get; set; }
    ILayer Layer { get; set; }
    double LineSpacing { get; set; }
    TextLineSpacingTypeEnum LineSpacingType { get; set; }
    IPoint2d Position { get; set; }
    double WidthScale { get; set; }
    VerticalTextAlignmentEnum StackedTextPosition { get; set; }
    IGeometryIntent _AttachedEntity { get; set; }
    IBox2d RangeBox { get; }
    IDimensionStyle DimensionStyle { get; set; }
    ILeader Leader { get; }
    double Rotation { get; set; }
    IUnitAttributes UnitAttributes { get; }
    IColor BackgroundColor { get; set; }
    bool UseBackgroundColor { get; set; }
    string FormattedPunchNote { get; set; }
    string FormattedQuantityNote { get; set; }
    bool HideValue { get; set; }
    IGeometryIntent PunchEdge { get; set; }
    PunchNoteQuantityEnum QuantityDefinition { get; set; }
    bool UsePartUnits { get; set; }
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    void Delete();
}
