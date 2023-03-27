namespace Oblikovati.Domain.Contracts;

public interface ICompositeiMateDefinition : IList<ICompositeiMateDefinition>
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
    int Count { get; }
    void Delete();
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    IEnumerator GetEnumerator();
    void RemoveItems(IObjectCollection iMates);
}
