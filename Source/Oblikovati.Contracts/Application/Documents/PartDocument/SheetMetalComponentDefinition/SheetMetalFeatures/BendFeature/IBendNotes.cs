using Oblikovati.Contracts.Application.Documents.DrawingDocument;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.SheetMetalComponentDefinition.SheetMetalFeatures.
    BendFeature;

public interface IBendNotes : IList<IBendNotes>
{
    IBendNote Item { get; }
    IBendNote Add(IDrawingCurve BendEdge, object DimensionStyle);
}