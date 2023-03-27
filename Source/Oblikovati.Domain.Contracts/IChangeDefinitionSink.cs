namespace Oblikovati.Domain.Contracts;

public interface IChangeDefinitionSink
{
    void OnReplay(INameValueMap Context, out IChangeProcessor ResultProcessor);
}
