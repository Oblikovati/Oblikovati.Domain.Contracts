namespace Oblikovati.Domain.Contracts;

public interface IAttributeSets : IList<IAttributeSets>
{

    int Count { get; }
    IAttributeSet Item { get; }
    bool NameIsUsed { get; }
    IDataIO DataIO { get; }
    IEnumerator GetEnumerator();
    IAttributeSet Add(string AttributeSetName, bool CopyWithOwner);
    IAttributeSet AddTransient(string AttributeSetName, bool CopyWithOwner);
    bool ParentAvailable(out object Parent, out object Context);
}
