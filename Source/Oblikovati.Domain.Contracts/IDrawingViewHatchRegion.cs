namespace Oblikovati.Domain.Contracts;

public interface IDrawingViewHatchRegion
{

    IDrawingView Parent { get; }
    double Angle { get; set; }
    bool ByMaterial { get; set; }
    IColor Color { get; set; }
    bool DoublePattern { get; set; }
    IObjectCollection BoundaryGeometries { get; }
    IDrawingViewHatchAreas HatchAreas { get; }
    ILayer Layer { get; set; }
    double LineWeight { get; set; }
    IDrawingHatchPattern Pattern { get; set; }
    IBox2d RangeBox { get; }
    double Scale { get; set; }
    double Shift { get; set; }
    object SurfaceBody { get; }
    bool Visible { get; set; }
}
