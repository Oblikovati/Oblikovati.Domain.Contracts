namespace Oblikovati.Contracts.NotClassified;

public interface IContentQuerySink
{
    void OnCancel();
    void OnDone(string ResultXML);
}