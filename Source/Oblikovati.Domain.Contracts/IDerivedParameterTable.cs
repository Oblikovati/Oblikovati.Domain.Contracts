namespace Oblikovati.Domain.Contracts;

public interface IDerivedParameterTable
{

    IDerivedParameters DerivedParameters { get; }
    bool HasReferenceComponent { get; }
    IReferenceComponent ReferenceComponent { get; }
    IDocumentDescriptor ReferencedDocumentDescriptor { get; }
    IObjectCollection LinkedParameters { get; set; }
    IAttributeSets AttributeSets { get; }
    void Delete();
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
}
