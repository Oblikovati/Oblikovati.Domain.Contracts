namespace Oblikovati.Domain.Contracts;

public interface ISketchHatchRegion
{

    IDrawingSketch Parent { get; }
    double Angle { get; set; }
    IColor Color { get; set; }
    bool DoublePattern { get; set; }
    ILayer Layer { get; set; }
    double LineWeight { get; set; }
    IDrawingHatchPattern Pattern { get; set; }
    IProfile Profile { get; }
    double Scale { get; set; }
    double Shift { get; set; }
    void Delete();
}
