namespace Oblikovati.Domain.Contracts;

public interface IAnnotationPlaneProxy
{
    IAttributeSets AttributeSets { get; }
    IComponentDefinition Parent { get; }
    IAnnotationPlaneDefinition Definition { get; }
    IModelAnnotationsEnumerator Annotations { get; }
    IAnnotationPlane NativeObject { get; }
    IComponentOccurrence ContainingOccurrence { get; }
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
}
