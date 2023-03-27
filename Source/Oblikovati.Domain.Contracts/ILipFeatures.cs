namespace Oblikovati.Domain.Contracts;

public interface ILipFeatures : IList<ILipFeatures>
{

    ILipFeature Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
}
