namespace Oblikovati.Domain.Contracts;

public interface IDiameterModelDimensions : IList<IDiameterModelDimensions>
{
    int Count { get; }
    IDiameterModelDimension Item { get; }
    IEnumerator GetEnumerator();
    IDiameterModelDimension Add(IDiameterModelDimensionDefinition Definition);
    IDiameterModelDimensionDefinition CreateDefinition(IGeometryIntent Intent, IAnnotationPlaneDefinition AnnotationPlaneDefinition, IPoint LandingPosition);
}
