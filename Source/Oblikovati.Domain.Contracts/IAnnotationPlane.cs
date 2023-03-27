namespace Oblikovati.Domain.Contracts;

public interface IAnnotationPlane
{
    IAttributeSets AttributeSets { get; }
    IComponentDefinition Parent { get; }
    IAnnotationPlaneDefinition Definition { get; }
    IModelAnnotationsEnumerator Annotations { get; }
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
}
