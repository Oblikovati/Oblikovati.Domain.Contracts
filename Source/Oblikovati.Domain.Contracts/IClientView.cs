using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IClientView
{

    IClientViews Parent { get; }
    object Document { get; }
    ICamera Camera { get; }
    DisplayModeEnum DisplayMode { get; set; }
    int HWND { get; }
    bool BackgroundDisplay { get; set; }
    GroundShadowEnum GroundShadow { get; set; }
    double DisplayScaleFactor { get; set; }
    void Close();
    void Update(bool Interactive);
    void Animate(IMatrix TargetTransform, int NumberOfTransitions);
    void GetSubsetExtents(out int Top, out int Left, out int Width, out int Height);
}
