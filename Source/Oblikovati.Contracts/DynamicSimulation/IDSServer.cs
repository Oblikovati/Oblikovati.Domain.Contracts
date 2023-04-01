using Oblikovati.Contracts.ClientGraphics.ComponentDefinition;

namespace Oblikovati.Contracts.DynamicSimulation;

public interface IDSServer
{
    IDynamicSimulations GetDynamicSimulations(IComponentDefinition ComponentDefinition);
    void GetXMLData(object DocumentName, string ControlData, out string OutputData, out string Status);
}