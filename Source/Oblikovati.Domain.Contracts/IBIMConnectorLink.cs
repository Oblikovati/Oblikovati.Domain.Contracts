namespace Oblikovati.Domain.Contracts;

public interface IBIMConnectorLink
{

    IBIMConnector ConnectorOne { get; }
    IBIMConnector ConnectorTwo { get; }
    string Name { get; set; }
    void Delete();
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
}
