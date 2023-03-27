using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IModelAnnotationText
{
    IModelAnnotation Parent { get; }
    IColor Color { get; set; }
    string Font { get; set; }
    string Text { get; }
    string FormattedText { get; set; }
    HorizontalTextAlignmentEnum HorizontalJustification { get; set; }
    VerticalTextAlignmentEnum VerticalJustification { get; set; }
    double LineSpacing { get; set; }
    TextLineSpacingTypeEnum LineSpacingType { get; set; }
    IPoint Position { get; set; }
    double WidthScale { get; set; }
    double Size { get; set; }
    VerticalTextAlignmentEnum StackedTextPosition { get; set; }
}
