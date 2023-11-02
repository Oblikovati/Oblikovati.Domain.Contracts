using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition;
using Oblikovati.Contracts.Application.TransientGeometry;
using Oblikovati.Contracts.NotClassified;

namespace Oblikovati.Contracts.ModelAnnotations;

public interface IDiameterModelDimensions : IList<IDiameterModelDimensions>
{
    IDiameterModelDimension Item { get; }

    IDiameterModelDimension Add(IDiameterModelDimensionDefinition Definition);

    IDiameterModelDimensionDefinition CreateDefinition(IGeometryIntent Intent,
        IAnnotationPlaneDefinition AnnotationPlaneDefinition, IPoint LandingPosition);
}