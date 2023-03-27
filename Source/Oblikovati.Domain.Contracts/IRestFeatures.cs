namespace Oblikovati.Domain.Contracts;

public interface IRestFeatures : IList<IRestFeatures>
{

    IRestFeature Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
}
