using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IBIMConnectorDefinition
{

    IBIMConnector Parent { get; }
    BIMConnectorShapeEnum ConnectorShape { get; }
    IUnitVector Direction { get; }
    IObjectCollection Geometry { get; }
    IPoint Origin { get; }
    void ReverseDirection();
    void SetShape(IObjectCollection Geometry, BIMConnectorShapeEnum ConnectorShape);
}
