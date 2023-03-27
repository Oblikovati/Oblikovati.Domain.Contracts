namespace Oblikovati.Domain.Contracts;

public interface ISketchDrivenPatternFeatures : IList<ISketchDrivenPatternFeatures>
{

    ISketchDrivenPatternFeature Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
    ISketchDrivenPatternFeature Add(ISketchDrivenPatternDefinition Definition);
    ISketchDrivenPatternDefinition CreateDefinition(IObjectCollection ParentFeatures, object Sketch, object BasePoint, object ReferenceFaces);
}
