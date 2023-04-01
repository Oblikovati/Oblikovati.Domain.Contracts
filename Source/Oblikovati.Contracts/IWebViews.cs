namespace Oblikovati.Contracts;

public interface IWebViews : IList<IWebViews>
{
    IWebView Item { get; }


    IWebView Add(object InternalName);
}