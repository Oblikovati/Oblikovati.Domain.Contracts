namespace Oblikovati.Domain.Contracts;

public interface IBalloonTipSink
{
    void OnClick(INameValueMap Context);
    void OnDisplay(ref bool Cancel);
}
