namespace Oblikovati.Contracts.NotClassified;

public interface IWebViews : IList<IWebViews>
{
    IWebView Item { get; }


    IWebView Add(object InternalName);
}