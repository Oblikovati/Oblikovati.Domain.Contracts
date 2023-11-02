using Oblikovati.Contracts.Enums;
using Oblikovati.Contracts.NotClassified;

namespace Oblikovati.Contracts.Application.Documents.Document;

public interface IPrintManager
{
    string Printer { get; set; }
    int NumberOfCopies { get; set; }
    PrintOrientationEnum Orientation { get; set; }
    PaperSizeEnum PaperSize { get; set; }
    double PaperHeight { get; set; }
    double PaperWidth { get; set; }
    int PaperSource { get; set; }
    PrintColorModeEnum ColorMode { get; set; }
    int PrinterDeviceContext { get; set; }
    void SubmitPrint();
    void PrintToFile(string FileName);
    void SetCurrentView(IClientView CurrentView);
}