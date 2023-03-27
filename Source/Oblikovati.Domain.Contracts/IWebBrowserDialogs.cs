namespace Oblikovati.Domain.Contracts;

public interface IWebBrowserDialogs : IList<IWebBrowserDialog>
{
    IWebBrowserDialog this[string Index] { get; }
    IWebBrowserDialog Add(object InternalName, bool Modal);
}
