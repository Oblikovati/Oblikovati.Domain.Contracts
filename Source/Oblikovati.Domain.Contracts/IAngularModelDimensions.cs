namespace Oblikovati.Domain.Contracts;

public interface IAngularModelDimensions : IList<IAngularModelDimensions>
{
    int Count { get; }
    IAngularModelDimension Item { get; }
    IEnumerator GetEnumerator();
    IAngularModelDimension Add(IAngularModelDimensionDefinition Definition);
    IAngularModelDimensionDefinition CreateDefinition(IGeometryIntent IntentOne, IGeometryIntent IntentTwo, IGeometryIntent IntentThree, IAnnotationPlaneDefinition AnnotationPlaneDefinition, IPoint TextPosition);
}
