using Oblikovati.Contracts.Application.TransientGeometry;
using Oblikovati.Contracts.Application.TransientObjects.Math;
using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.BIMExchange;

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