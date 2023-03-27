using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IBIMConduitConnectorDefinition
{

    IBIMConnector Parent { get; }
    BIMConnectorShapeEnum ConnectorShape { get; }
    IUnitVector Direction { get; }
    IObjectCollection Geometry { get; }
    IPoint Origin { get; }
    BIMConduitConnectionTypeEnum ConnectionType { get; set; }
    object Diameter { get; }
    object DiameterOverride { get; set; }
    void ReverseDirection();
    void SetShape(IObjectCollection Geometry, BIMConnectorShapeEnum ConnectorShape);
}
