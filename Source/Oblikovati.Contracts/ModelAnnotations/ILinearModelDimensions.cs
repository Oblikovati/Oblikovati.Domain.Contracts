using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition;
using Oblikovati.Contracts.Application.TransientGeometry;
using Oblikovati.Contracts.Enums;
using Oblikovati.Contracts.NotClassified;

namespace Oblikovati.Contracts.ModelAnnotations;

public interface ILinearModelDimensions : IList<ILinearModelDimensions>
{
    ILinearModelDimension Item { get; }

    ILinearModelDimension Add(ILinearModelDimensionDefinition Definition);

    ILinearModelDimensionDefinition CreateDefinition(IGeometryIntent IntentOne, IGeometryIntent IntentTwo,
        IAnnotationPlaneDefinition AnnotationPlaneDefinition, IPoint TextPosition, DimensionTypeEnum DimensionType);
}