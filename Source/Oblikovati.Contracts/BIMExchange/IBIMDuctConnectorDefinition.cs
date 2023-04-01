using Oblikovati.Contracts.Application.TransientGeometry;
using Oblikovati.Contracts.Application.TransientObjects.Math;
using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.BIMExchange;

public interface IBIMDuctConnectorDefinition
{
    IBIMConnector Parent { get; }
    BIMConnectorShapeEnum ConnectorShape { get; }
    IUnitVector Direction { get; }
    IObjectCollection Geometry { get; }
    IPoint Origin { get; }
    BIMDuctConnectionTypeEnum ConnectionType { get; set; }
    string Description { get; set; }
    object Diameter { get; }
    object DiameterOverride { get; set; }
    object Height { get; }
    object HeightOverride { get; set; }
    object Width { get; }
    object WidthOverride { get; set; }
    IUnitVector HeightDirection { get; }
    IUnitVector WidthDirection { get; }
    BIMDuctFlowConfigurationEnum FlowConfiguration { get; set; }
    BIMFlowDirectionEnum FlowDirection { get; set; }
    double FlowValue { get; set; }
    BIMDuctLossMethodEnum LossMethod { get; set; }
    double LossValue { get; set; }
    BIMDuctSystemTypeEnum SystemType { get; set; }
    bool ExposeFlowValueAsParameter { get; set; }
    object FlowValueParameter { get; set; }
    bool ExposeLossValueAsParameter { get; set; }
    object LossValueParameter { get; set; }
    bool ExposeDescriptionAsParameter { get; set; }
    object DescriptionParameter { get; set; }
    void ReverseDirection();
    void SetShape(IObjectCollection Geometry, BIMConnectorShapeEnum ConnectorShape);
}