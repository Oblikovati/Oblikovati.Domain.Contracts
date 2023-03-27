namespace Oblikovati.Domain.Contracts;

public interface IReplaceFaceFeatures : IList<IReplaceFaceFeatures>
{

    IReplaceFaceFeature Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
}
