using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition;
using Oblikovati.Contracts.Application.TransientGeometry;
using Oblikovati.Contracts.NotClassified;

namespace Oblikovati.Contracts.ModelAnnotations;

public interface IAngularModelDimensions : IList<IAngularModelDimensions>
{
    IAngularModelDimension Item { get; }

    IAngularModelDimension Add(IAngularModelDimensionDefinition Definition);

    IAngularModelDimensionDefinition CreateDefinition(IGeometryIntent IntentOne, IGeometryIntent IntentTwo,
        IGeometryIntent IntentThree, IAnnotationPlaneDefinition AnnotationPlaneDefinition, IPoint TextPosition);
}