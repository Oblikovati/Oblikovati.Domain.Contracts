using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IDrawingViewLabel
{

    IDrawingView Parent { get; }
    IColor Color { get; set; }
    string FormattedText { get; set; }
    HorizontalTextAlignmentEnum HorizontalJustification { get; set; }
    double LineSpacing { get; set; }
    TextLineSpacingTypeEnum LineSpacingType { get; set; }
    IPoint2d Position { get; set; }
    string Text { get; }
    VerticalTextAlignmentEnum VerticalJustification { get; set; }
    double WidthScale { get; set; }
    bool ConstrainToBorder { get; set; }
    ITextStyle TextStyle { get; set; }
    ILayer Layer { get; set; }
    VerticalTextAlignmentEnum StackedTextPosition { get; set; }
    IBox2d RangeBox { get; }
}
