using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.Headless;

public interface IHeadlessDrawingPrintManager
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
    PrintScaleModeEnum ScaleMode { get; set; }
    double Scale { get; set; }
    PrintRangeEnum PrintRange { get; set; }
    bool Rotate90Degrees { get; set; }
    bool AllColorsAsBlack { get; set; }
    bool RemoveLineWeights { get; set; }
    bool PrintExcludedSheets { get; set; }
    void SubmitPrint();
    void PrintToFile(string FileName);
    void SetCurrentView(IClientView CurrentView);
    void SetSheetRange(int FromSheet, int ToSheet);
    void GetSheetRange(out int FromSheet, out int ToSheet);
}