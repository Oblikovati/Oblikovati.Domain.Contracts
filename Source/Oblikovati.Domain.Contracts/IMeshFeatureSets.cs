namespace Oblikovati.Domain.Contracts;

public interface IMeshFeatureSets : IList<IMeshFeatureSets>
{

    int Count { get; }
    IMeshFeatureSet Item { get; }
    IEnumerator GetEnumerator();
    IMeshFeatureSet Add(string FullName);
}
