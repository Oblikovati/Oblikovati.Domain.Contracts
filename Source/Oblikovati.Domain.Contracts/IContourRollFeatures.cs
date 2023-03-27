namespace Oblikovati.Domain.Contracts;

public interface IContourRollFeatures : IList<IContourRollFeatures>
{

    IContourRollFeature Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
}
