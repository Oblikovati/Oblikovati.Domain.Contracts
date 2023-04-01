using Oblikovati.Contracts.Sketch2D;

namespace Oblikovati.Contracts.Attributes;

public interface IAttributeSets : IList<IAttributeSets>
{
    IAttributeSet Item { get; }
    bool NameIsUsed { get; }
    IDataIO DataIO { get; }

    IAttributeSet Add(string AttributeSetName, bool CopyWithOwner);
    IAttributeSet AddTransient(string AttributeSetName, bool CopyWithOwner);
    bool ParentAvailable(out object Parent, out object Context);
}