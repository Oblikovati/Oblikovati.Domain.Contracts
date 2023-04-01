using Oblikovati.Contracts.Application.TransientGeometry;
using Oblikovati.Contracts.Application.TransientObjects.Math;
using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.BIMExchange;

public interface IBIMPipeConnectorDefinition
{
    IBIMConnector Parent { get; }
    BIMConnectorShapeEnum ConnectorShape { get; }
    IUnitVector Direction { get; }
    IObjectCollection Geometry { get; }
    IPoint Origin { get; }
    bool AllowSlopeAdjustment { get; set; }
    BIMPipeConnectionTypeEnum ConnectionType { get; set; }
    string Description { get; set; }
    object Diameter { get; }
    object DiameterOverride { get; set; }
    BIMPipeFlowConfigurationEnum FlowConfiguration { get; set; }
    BIMFlowDirectionEnum FlowDirection { get; set; }
    double FlowValue { get; set; }
    BIMPipeLossMethodEnum LossMethod { get; set; }
    double LossValue { get; set; }
    object NominalDiameter { get; set; }
    BIMPipeSystemTypeEnum SystemType { get; set; }
    bool ExposeFlowValueAsParameter { get; set; }
    object FlowValueParameter { get; set; }
    bool ExposeLossValueAsParameter { get; set; }
    object LossValueParameter { get; set; }
    bool ExposeAllowSlopeAdjustmentAsParameter { get; set; }
    object AllowSlopeAdjustmentParameter { get; set; }
    bool ExposeDescriptionAsParameter { get; set; }
    object DescriptionParameter { get; set; }
    void ReverseDirection();
    void SetShape(IObjectCollection Geometry, BIMConnectorShapeEnum ConnectorShape);
}