namespace Oblikovati.Domain.Contracts;

public interface IBIMComponentPropertySets : IList<IBIMComponentPropertySets>
{

    int Count { get; }
    IBIMComponentPropertySet Item { get; }
    IEnumerator GetEnumerator();
}
