using Oblikovati.Contracts.Attributes;
using Oblikovati.Contracts.NotClassified;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.iMateDefinitions;

public interface IiMateDefinition
{
    string Identifier { get; }
    string Name { get; set; }
    int SequenceIndex { get; set; }
    bool Suppressed { get; set; }
    IAttributeSets AttributeSets { get; }
    object MatchList { get; set; }
    IiMateDefinition ReferencedEntity { get; }
    bool HasReferenceComponent { get; }
    IReferenceComponent ReferenceComponent { get; }
    bool Exported { get; set; }
    void Delete();
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
}