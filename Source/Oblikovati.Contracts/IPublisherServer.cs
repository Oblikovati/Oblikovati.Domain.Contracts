using Oblikovati.Contracts.Application.Documents.PresentationDocument;

namespace Oblikovati.Contracts;

public interface IPublisherServer
{
    void GetXMLData(object DocumentName, string ControlData, out string OutputData, out string Status);
    IPresentationScene GetActivePresentationScene(IPresentationDocument Document);
    IPresentationScenes GetPresentationScenes(IPresentationDocument Document);
}