using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface ITextBox
{

    ISketch Parent { get; }
    string FormattedText { get; set; }
    string Text { get; set; }
    ITextStyle Style { get; set; }
    HorizontalTextAlignmentEnum HorizontalJustification { get; set; }
    VerticalTextAlignmentEnum VerticalJustification { get; set; }
    double WidthScale { get; set; }
    double Rotation { get; set; }
    bool Fitted { get; }
    double FittedTextHeight { get; }
    double FittedTextWidth { get; }
    IPoint2d Origin { get; set; }
    ISketchPoint OriginSketchPoint { get; }
    double Width { get; set; }
    double Height { get; set; }
    TextLineSpacingTypeEnum LineSpacingType { get; set; }
    double LineSpacing { get; set; }
    IAttributeSets AttributeSets { get; }
    bool ShowBoundaries { get; set; }
    ISketchEntitiesEnumerator BoundaryGeometry { get; }
    ILayer Layer { get; set; }
    IColor Color { get; set; }
    bool SingleLineText { get; set; }
    VerticalTextAlignmentEnum StackedTextPosition { get; set; }
    IBox2d RangeBox { get; }
    ISketchBlock ContainingSketchBlock { get; }
    ISketchBlocksEnumerator SketchBlockPath { get; }
    IColor BackgroundColor { get; set; }
    bool UseBackgroundColor { get; set; }
    void Delete();
    void GetColor(out byte Red, out byte Green, out byte Blue);
    void SetColor(byte Red, byte Green, byte Blue);
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    void GetFacetsInfo(out int VertexCount, out int FacetCount, out List<double> VertexCoordinates, out List<int> VertexIndices);
    ISketchEntitiesEnumerator ConvertToGeometry(string SHXFont, object UseBigFont, object BigFont);
}
