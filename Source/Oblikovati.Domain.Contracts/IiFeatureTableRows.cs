namespace Oblikovati.Domain.Contracts;

public interface IiFeatureTableRows : IList<IiFeatureTableRows>
{

    int Count { get; }
    IiFeatureTableRow Item { get; }
    IEnumerator GetEnumerator();
}
