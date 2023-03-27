namespace Oblikovati.Domain.Contracts;

public interface IExtendFeatures : IList<IExtendFeatures>
{

    IExtendFeature Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
}
