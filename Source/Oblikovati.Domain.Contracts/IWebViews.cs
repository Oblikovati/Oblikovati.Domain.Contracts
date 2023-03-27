namespace Oblikovati.Domain.Contracts;

public interface IWebViews : IList<IWebViews>
{
    IWebView Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
    IWebView Add(object InternalName);
}
