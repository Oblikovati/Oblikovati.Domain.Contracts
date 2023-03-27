namespace Oblikovati.Domain.Contracts;

public interface IContentCenterDialogEventsSink
{
    void OnSelect(INameValueMap Context, INameValueMap Options, out string ResultXML);
    void OnSelectionCommit(INameValueMap Context, INameValueMap Options, out string ResultXML);
    void OnTerminate(bool Cancelled, INameValueMap Context);
}
