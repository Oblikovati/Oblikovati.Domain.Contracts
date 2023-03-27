using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface ITutorialsManager
{


    bool DisplayBuiltInTutorials { get; set; }
    bool InTutorialRecordStatus { get; set; }
    void ShowTutorialCommandIndicator(string CommandID);
    void ShowTutorialCommandIndicatorWithStyles(string CommandID, ColorStyleEnum Color, ShapeStyleEnum Shape);
    void ClearTutorialCommandIndicator();
    void ShowTutorialHotspot(string AttibuteNAME);
    void ClearTutorialHotspot();
    void PlayVideo(string VideoPath);
    void FlushDocument(string FilePath, ref IDocument SceneDoc);
    void ShowTutorialBrowserIndicator(string BrowserNodeFullPath);
    void ShowTutorialBrowserIndicatorWithStyles(string BrowserNodeFullPath, ColorStyleEnum Color, ShapeStyleEnum Shape);
    void ClearTutorialBrowserIndicator();
    void SetDocumentTabTutorialColor(IDocument DocumentObject);
}
