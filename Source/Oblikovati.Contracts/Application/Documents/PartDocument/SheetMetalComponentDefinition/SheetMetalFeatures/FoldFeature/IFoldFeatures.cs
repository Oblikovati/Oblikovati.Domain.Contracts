using Oblikovati.Contracts.Sketch2D;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.SheetMetalComponentDefinition.SheetMetalFeatures.
    FoldFeature;

public interface IFoldFeatures : IList<IFoldFeatures>
{
    IFoldFeature Item { get; }


    IFoldFeature Add(IFoldDefinition FoldDefinition);
    IFoldDefinition CreateFoldDefinition(ISketchLine BendLine, object BendAngle);
}