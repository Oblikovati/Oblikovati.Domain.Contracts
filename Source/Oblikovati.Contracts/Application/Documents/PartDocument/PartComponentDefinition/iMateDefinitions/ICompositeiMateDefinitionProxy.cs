using Oblikovati.Contracts.Application.Documents.AssemblyDocument.AssemblyComponentDefinition.ComponentOccurence;
using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Attributes;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.iMateDefinitions;

public interface ICompositeiMateDefinitionProxy : IList<ICompositeiMateDefinitionProxy>
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
    IiMateDefinition Item { get; }

    IiMateDefinition NativeObject { get; }
    IComponentOccurrence ContainingOccurrence { get; }
    bool IsConsumed { get; }
    void Delete();
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);

    void RemoveItems(IObjectCollection iMates);
}