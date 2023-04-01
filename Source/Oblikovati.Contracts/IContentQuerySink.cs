namespace Oblikovati.Contracts;

public interface IContentQuerySink
{
    void OnCancel();
    void OnDone(string ResultXML);
}