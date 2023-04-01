using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.BIMExchange;

public interface IBIMConnectors : IList<IBIMConnectors>
{
    IBIMConnector Item { get; }
    IBIMConnector Add(IBIMConnectorDefinition Definition, string Name);

    IBIMCableTrayConnectorDefinition CreateCableTrayConnectorDefinition(IObjectCollection Geometry,
        BIMConnectorShapeEnum ConnectorShape);

    IBIMConduitConnectorDefinition CreateConduitConnectorDefinition(IObjectCollection Geometry,
        BIMConnectorShapeEnum ConnectorShape);

    IBIMDuctConnectorDefinition CreateDuctConnectorDefinition(IObjectCollection Geometry,
        BIMConnectorShapeEnum ConnectorShape);

    IBIMElectricalConnectorDefinition CreateElectricalConnectorDefinition(IObjectCollection Geometry);

    IBIMPipeConnectorDefinition CreatePipeConnectorDefinition(IObjectCollection Geometry,
        BIMConnectorShapeEnum ConnectorShape);
}