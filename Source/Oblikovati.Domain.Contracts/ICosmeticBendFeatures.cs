namespace Oblikovati.Domain.Contracts;

public interface ICosmeticBendFeatures : IList<ICosmeticBendFeatures>
{

    ICosmeticBendFeature Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
}
