using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface ILinearModelDimensions : IList<ILinearModelDimensions>
{
    int Count { get; }
    ILinearModelDimension Item { get; }
    IEnumerator GetEnumerator();
    ILinearModelDimension Add(ILinearModelDimensionDefinition Definition);
    ILinearModelDimensionDefinition CreateDefinition(IGeometryIntent IntentOne, IGeometryIntent IntentTwo, IAnnotationPlaneDefinition AnnotationPlaneDefinition, IPoint TextPosition, DimensionTypeEnum DimensionType);
}
