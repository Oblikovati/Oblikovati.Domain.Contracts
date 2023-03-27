using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

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
