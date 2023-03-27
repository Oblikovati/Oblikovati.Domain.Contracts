namespace Oblikovati.Domain.Contracts;

public interface IGroundPlaneSettings
{

    bool AutoResize { get; set; }
    IColor Color { get; set; }
    bool DisplayGridLines { get; set; }
    double HeightOffset { get; set; }
    double MinorGridLineSpacing { get; set; }
    int MinorLinesPerMajorGridLine { get; set; }
    double Opacity { get; set; }
    IPlane Plane { get; }
    object Position { get; set; }
    double ReflectionBlur { get; set; }
    double ReflectionBlurFalloff { get; set; }
    double Reflectivity { get; set; }
    IUnitVector FrontDirection { get; }
    IUnitVector UpDirection { get; }
    void GetSize(out IPoint PointOne, out IPoint PointTwo);
    void SetSize(IPoint PointOne, IPoint PointTwo);
}
