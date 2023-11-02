using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition;
using Oblikovati.Contracts.Application.TransientGeometry;
using Oblikovati.Contracts.NotClassified;

namespace Oblikovati.Contracts.ModelAnnotations;

public interface IRadiusModelDimensions : IList<IRadiusModelDimensions>
{
    IRadiusModelDimension Item { get; }

    IRadiusModelDimension Add(IRadiusModelDimensionDefinition Definition);

    IRadiusModelDimensionDefinition CreateDefinition(IGeometryIntent Intent,
        IAnnotationPlaneDefinition AnnotationPlaneDefinition, IPoint LandingPosition);
}