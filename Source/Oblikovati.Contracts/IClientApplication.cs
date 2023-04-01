namespace Oblikovati.Contracts;

public interface IClientApplication
{
    void GetXMLData(object DocumentName, string ControlData, out string OutputData, out string Status);
    void PutXMLData(object DocumentName, string ControlData, string InputData, out string Status);
}