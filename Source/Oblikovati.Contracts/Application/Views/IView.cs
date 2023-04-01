using Oblikovati.Contracts.Application.Documents.Document;
using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Application.ViewFramesEnumerator;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.Views;

public interface IView
{
    IDocument Parent { get; }
    IDocument Document { get; }
    ICamera Camera { get; }
    string Caption { get; set; }
    bool Visible { get; set; }
    DisplayModeEnum DisplayMode { get; set; }
    int Top { get; set; }
    int Left { get; set; }
    int Height { get; set; }
    int Width { get; set; }
    WindowsSizeEnum WindowState { get; set; }
    GroundShadowEnum GroundShadow { get; set; }
    bool ViewCubeEnabled { get; set; }
    bool SteeringWheelEnabled { get; set; }
    bool NavigationBarEnabled { get; set; }
    bool ShowGroundPlane { get; set; }
    bool ShowGroundReflections { get; set; }
    bool ShowAmbientShadows { get; set; }
    bool ShowGroundShadows { get; set; }
    bool ShowObjectShadows { get; set; }
    bool RayTracing { get; set; }
    RayTracingQualityEnum RayTracingQuality { get; set; }
    bool AreTexturesOn { get; set; }
    bool IsRayTracingPaused { get; set; }
    double RayTracingProgress { get; }
    IViewFrame ViewFrame { get; }
    IViewTab ViewTab { get; }
    void Activate();
    void Close();
    void Update();
    void Fit(bool DoUpdate);
    void GetWindowExtents(out int Top, out int Left, out int Height, out int Width);
    void SaveAsBitmap(string FullFileName, int Width, int Height);
    void Move(int Top, int Left, int Height, int Width);
    void GoHome();
    void ResetFront();
    void SetCurrentAsFront();
    void SetCurrentAsTop();
    void SetCurrentAsHome(bool FitToView);
    void SaveAsBitmapWithRayTracing(string FullFileName);
    void SaveAsBitmapWithOptions(string FullFileName, int Width, int Height, INameValueMap Options);
}