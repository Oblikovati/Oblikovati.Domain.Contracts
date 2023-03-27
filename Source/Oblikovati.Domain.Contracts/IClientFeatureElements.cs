namespace Oblikovati.Domain.Contracts;

public interface IClientFeatureElements : IList<IClientFeatureElements>
{

    int Count { get; }
    IClientFeatureElement Item { get; }
    IEnumerator GetEnumerator();
    IClientFeatureElement Add(object Element, bool BrowserVisible);
}
