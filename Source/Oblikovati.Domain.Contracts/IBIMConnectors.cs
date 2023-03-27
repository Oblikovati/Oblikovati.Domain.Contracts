using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IBIMConnectors : IList<IBIMConnectors>
{

    int Count { get; }
    IBIMConnector Item { get; }
    IBIMConnector Add(IBIMConnectorDefinition Definition, string Name);
    IBIMCableTrayConnectorDefinition CreateCableTrayConnectorDefinition(IObjectCollection Geometry, BIMConnectorShapeEnum ConnectorShape);
    IBIMConduitConnectorDefinition CreateConduitConnectorDefinition(IObjectCollection Geometry, BIMConnectorShapeEnum ConnectorShape);
    IBIMDuctConnectorDefinition CreateDuctConnectorDefinition(IObjectCollection Geometry, BIMConnectorShapeEnum ConnectorShape);
    IBIMElectricalConnectorDefinition CreateElectricalConnectorDefinition(IObjectCollection Geometry);
    IBIMPipeConnectorDefinition CreatePipeConnectorDefinition(IObjectCollection Geometry, BIMConnectorShapeEnum ConnectorShape);
    IEnumerator GetEnumerator();
}
