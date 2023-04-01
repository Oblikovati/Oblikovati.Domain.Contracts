namespace Oblikovati.Contracts.ModelAnnotations;

public interface IModelCompositeAnnotations : IList<IModelCompositeAnnotations>
{
    IModelCompositeAnnotation Item { get; }

    IModelCompositeAnnotation Add(IModelCompositeAnnotationDefinition Definition, object ClientId);
    IModelCompositeAnnotationDefinition CreateDefinition(IModelAnnotation BaseAnnotation, object AnnotationType);
}