using Oblikovati.Contracts.Application.Documents.Document;
using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Attributes;
using Oblikovati.Contracts.NotClassified;

namespace Oblikovati.Contracts.Parameters;

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