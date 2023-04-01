namespace Oblikovati.Contracts;

public interface IMidSurfaceThickness
{
    double Maximum { get; }
    double Minimum { get; }
    IFace GetSourceFace();
}