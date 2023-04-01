using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.Headless;

public interface IHeadlessPrintManager
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