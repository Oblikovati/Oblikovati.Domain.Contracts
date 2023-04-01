using Oblikovati.Contracts.Application.TransientGeometry;
using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.ModelAnnotations;

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