namespace Oblikovati.Domain.Contracts;

public interface IiFeatureTableColumns : IList<IiFeatureTableColumns>
{

    int Count { get; }
    IiFeatureTableColumn Item { get; }
    IEnumerator GetEnumerator();
}
