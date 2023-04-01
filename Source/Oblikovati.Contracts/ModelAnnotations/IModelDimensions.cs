namespace Oblikovati.Contracts.ModelAnnotations;

public interface IModelDimensions : IList<IModelDimensions>
{
    IAngularModelDimensions AngularModelDimensions { get; }

    IDiameterModelDimensions DiameterModelDimensions { get; }
    ILinearModelDimensions LinearModelDimensions { get; }
    IRadiusModelDimensions RadiusModelDimensions { get; }
    IModelDimension Item { get; }
}