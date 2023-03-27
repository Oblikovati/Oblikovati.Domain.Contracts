namespace Oblikovati.Domain.Contracts;

public interface IFeaturePatternElements : IList<IFeaturePatternElements>
{

    IFeaturePatternElement Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
}
