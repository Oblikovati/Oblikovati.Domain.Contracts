namespace Oblikovati.Domain.Contracts;

public interface IRadiusModelDimensions : IList<IRadiusModelDimensions>
{
    int Count { get; }
    IRadiusModelDimension Item { get; }
    IEnumerator GetEnumerator();
    IRadiusModelDimension Add(IRadiusModelDimensionDefinition Definition);
    IRadiusModelDimensionDefinition CreateDefinition(IGeometryIntent Intent, IAnnotationPlaneDefinition AnnotationPlaneDefinition, IPoint LandingPosition);
}
