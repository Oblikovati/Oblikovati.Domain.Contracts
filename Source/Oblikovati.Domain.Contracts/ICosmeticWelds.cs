namespace Oblikovati.Domain.Contracts;

public interface ICosmeticWelds : IList<ICosmeticWelds>
{

    int Count { get; }
    ICosmeticWeld Item { get; }
    IEnumerator GetEnumerator();
    ICosmeticWeld Add(ICosmeticWeldDefinition CosmeticWeldDefinition);
    ICosmeticWeldDefinition CreateDefinition(IEdgeCollection Edges);
}
