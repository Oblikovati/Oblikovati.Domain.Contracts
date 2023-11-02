using Oblikovati.Contracts.Application.Documents.PartDocument.SheetMetalComponentDefinition;
using Oblikovati.Contracts.Application.TransientGeometry;
using Oblikovati.Contracts.Application.TransientObjects.Math;
using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Attributes;
using Oblikovati.Contracts.Enums;
using Oblikovati.Contracts.NotClassified;

namespace Oblikovati.Contracts.Application.Documents.DrawingDocument;

public interface IDrawingNote
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
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    void Delete();
}