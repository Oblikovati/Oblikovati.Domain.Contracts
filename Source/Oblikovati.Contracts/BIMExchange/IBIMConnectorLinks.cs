namespace Oblikovati.Contracts.BIMExchange;

public interface IBIMConnectorLinks : IList<IBIMConnectorLinks>
{
    IBIMConnectorLink Item { get; }
    IBIMConnectorLink Add(IBIMConnector ConnectorOne, IBIMConnector ConnectorTwo);
}