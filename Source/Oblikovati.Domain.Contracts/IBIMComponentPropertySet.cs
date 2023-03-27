namespace Oblikovati.Domain.Contracts;

public interface IBIMComponentPropertySet : IList<IBIMComponentPropertySet>
{

    IBIMComponent Parent { get; }
    int Count { get; }
    IBIMComponentProperty Item { get; }
    string InternalName { get; }
    string Name { get; }
    IEnumerator GetEnumerator();
}
