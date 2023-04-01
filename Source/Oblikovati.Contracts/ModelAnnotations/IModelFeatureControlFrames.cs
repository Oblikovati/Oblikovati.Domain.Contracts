using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition;
using Oblikovati.Contracts.Application.TransientGeometry;

namespace Oblikovati.Contracts.ModelAnnotations;

public interface IModelFeatureControlFrames : IList<IModelFeatureControlFrames>
{
    IModelFeatureControlFrame Item { get; }

    IModelFeatureControlFrame Add(IModelFeatureControlFrameDefinition Definition);

    IModelFeatureControlFrameDefinition CreateDefinition(IGeometryIntent Intent,
        IAnnotationPlaneDefinition AnnotationPlaneDefinition, IPoint LandingPosition);
}