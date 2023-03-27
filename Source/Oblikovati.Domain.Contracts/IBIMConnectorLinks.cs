namespace Oblikovati.Domain.Contracts;

public interface IBIMConnectorLinks : IList<IBIMConnectorLinks>
{

    int Count { get; }
    IBIMConnectorLink Item { get; }
    IBIMConnectorLink Add(IBIMConnector ConnectorOne, IBIMConnector ConnectorTwo);
    IEnumerator GetEnumerator();
}
