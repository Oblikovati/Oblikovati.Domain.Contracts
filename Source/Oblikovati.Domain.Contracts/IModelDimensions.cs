namespace Oblikovati.Domain.Contracts;

public interface IModelDimensions : IList<IModelDimensions>
{
    IAngularModelDimensions AngularModelDimensions { get; }
    int Count { get; }
    IDiameterModelDimensions DiameterModelDimensions { get; }
    ILinearModelDimensions LinearModelDimensions { get; }
    IRadiusModelDimensions RadiusModelDimensions { get; }
    IModelDimension Item { get; }
    IEnumerator GetEnumerator();
}
