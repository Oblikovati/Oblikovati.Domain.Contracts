namespace Oblikovati.Contracts.NotClassified;

public interface IMidSurfaceThickness
{
    double Maximum { get; }
    double Minimum { get; }
    IFace GetSourceFace();
}