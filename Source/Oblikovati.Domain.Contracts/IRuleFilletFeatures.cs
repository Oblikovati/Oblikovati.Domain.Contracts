namespace Oblikovati.Domain.Contracts;

public interface IRuleFilletFeatures : IList<IRuleFilletFeatures>
{

    IRuleFilletFeature Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
}
