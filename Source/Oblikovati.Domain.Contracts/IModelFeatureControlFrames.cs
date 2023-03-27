namespace Oblikovati.Domain.Contracts;

public interface IModelFeatureControlFrames : IList<IModelFeatureControlFrames>
{
    int Count { get; }
    IModelFeatureControlFrame Item { get; }
    IEnumerator GetEnumerator();
    IModelFeatureControlFrame Add(IModelFeatureControlFrameDefinition Definition);
    IModelFeatureControlFrameDefinition CreateDefinition(IGeometryIntent Intent, IAnnotationPlaneDefinition AnnotationPlaneDefinition, IPoint LandingPosition);
}
