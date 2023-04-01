using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.ClientGraphics.ComponentDefinition;

namespace Oblikovati.Contracts.BIMExchange;

public interface IBIMComponent
{
    IBIMComponentDescription ComponentDescription { get; }
    IBIMConnectors Connectors { get; }
    IBIMConnectorLinks ConnectorLinks { get; }
    IComponentDefinition ComponentDefinition { get; }
    bool LiveUpdate { get; set; }
    void ExportBuildingComponent(string FullFileName);
    void ExportBuildingComponentWithOptions(string FullFileName, INameValueMap pOptions);
}