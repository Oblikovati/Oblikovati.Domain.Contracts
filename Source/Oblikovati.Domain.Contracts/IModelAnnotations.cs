using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IModelAnnotations : IList<IModelAnnotations>
{
    int Count { get; }
    IModelAnnotation Item { get; }
    IModelFeatureControlFrames ModelFeatureControlFrames { get; }
    IModelSurfaceTextureSymbols ModelSurfaceTextureSymbols { get; }
    IModelDimensions ModelDimensions { get; }
    IModelHoleThreadNotes ModelHoleThreadNotes { get; }
    IModelLeaderNotes ModelLeaderNotes { get; }
    IModelDatumIdentifiers ModelDatumIdentifiers { get; }
    IModelCompositeAnnotations ModelCompositeAnnotations { get; }
    IModelGeneralNotes ModelGeneralNotes { get; }
    IEnumerator GetEnumerator();
    IAnnotationPlaneDefinitionsEnumerator CreateAnnotationPlaneDefinitionUsingIntents(ObjectTypeEnum AnnotationType, IGeometryIntent IntentOne, object IntentTwo, object IntentThree, object XAxis);
    IAnnotationPlaneDefinition CreateAnnotationPlaneDefinitionUsingPlane(object Plane, object XAxisDirection);
}
