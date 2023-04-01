using Oblikovati.Contracts.Application.TransientGeometry;
using Oblikovati.Contracts.Application.TransientObjects.Math;
using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.BIMExchange;

public interface IBIMCableTrayConnectorDefinition
{
    IBIMConnector Parent { get; }
    BIMConnectorShapeEnum ConnectorShape { get; }
    IUnitVector Direction { get; }
    IObjectCollection Geometry { get; }
    IPoint Origin { get; }
    BIMCableTrayConnectionTypeEnum ConnectionType { get; set; }
    object Height { get; }
    object HeightOverride { get; set; }
    object Width { get; }
    object WidthOverride { get; set; }
    IUnitVector HeightDirection { get; }
    IUnitVector WidthDirection { get; }
    void ReverseDirection();
    void SetShape(IObjectCollection Geometry, BIMConnectorShapeEnum ConnectorShape);
}