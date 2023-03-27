namespace Oblikovati.Domain.Contracts;

public interface IModelCompositeAnnotations : IList<IModelCompositeAnnotations>
{
    int Count { get; }
    IModelCompositeAnnotation Item { get; }
    IEnumerator GetEnumerator();
    IModelCompositeAnnotation Add(IModelCompositeAnnotationDefinition Definition, object ClientId);
    IModelCompositeAnnotationDefinition CreateDefinition(IModelAnnotation BaseAnnotation, object AnnotationType);
}
