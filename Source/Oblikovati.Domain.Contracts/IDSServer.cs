namespace Oblikovati.Domain.Contracts;

public interface IDSServer
{
    IDynamicSimulations GetDynamicSimulations(IComponentDefinition ComponentDefinition);
    void GetXMLData(object DocumentName, string ControlData, out string OutputData, out string Status);
}
