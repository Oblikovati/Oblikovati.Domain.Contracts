using Oblikovati.Contracts.Attributes;
using Oblikovati.Contracts.ClientGraphics.ComponentDefinition;
using Oblikovati.Contracts.ModelAnnotations;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition;

public interface IAnnotationPlane
{
    IAttributeSets AttributeSets { get; }
    IComponentDefinition Parent { get; }
    IAnnotationPlaneDefinition Definition { get; }
    IModelAnnotationsEnumerator Annotations { get; }
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
}