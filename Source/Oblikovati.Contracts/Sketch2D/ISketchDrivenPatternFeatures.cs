using Oblikovati.Contracts.Application.TransientObjects.Utility;

namespace Oblikovati.Contracts.Sketch2D;

public interface ISketchDrivenPatternFeatures : IList<ISketchDrivenPatternFeatures>
{
    ISketchDrivenPatternFeature Item { get; }


    ISketchDrivenPatternFeature Add(ISketchDrivenPatternDefinition Definition);

    ISketchDrivenPatternDefinition CreateDefinition(IObjectCollection ParentFeatures, object Sketch, object BasePoint,
        object ReferenceFaces);
}