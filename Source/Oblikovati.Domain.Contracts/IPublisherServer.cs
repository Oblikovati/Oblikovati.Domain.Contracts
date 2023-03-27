namespace Oblikovati.Domain.Contracts;

public interface IPublisherServer
{
    void GetXMLData(object DocumentName, string ControlData, out string OutputData, out string Status);
    IPresentationScene GetActivePresentationScene(I_PresentationDocument Document);
    IPresentationScenes GetPresentationScenes(I_PresentationDocument Document);
}
