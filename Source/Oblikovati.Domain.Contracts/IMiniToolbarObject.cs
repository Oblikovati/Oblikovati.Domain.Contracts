namespace Oblikovati.Domain.Contracts;

public interface IMiniToolbarObject
{
    IPoint2d Position { get; set; }
    bool ShowApply { get; set; }
    bool ShowCancel { get; set; }
    bool ShowOK { get; set; }
    bool Visible { get; set; }
    bool EnableApply { get; set; }
    bool EnableOK { get; set; }
    IMiniToolbarControls Controls { get; }
    bool ShowOptionBox { get; set; }
    bool ShowHandle { get; set; }
    int Height { get; }
    int Width { get; }
    bool IgnorePinnedPosition { get; set; }
    void Delete();
}
