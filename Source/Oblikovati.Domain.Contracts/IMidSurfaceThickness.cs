namespace Oblikovati.Domain.Contracts;

public interface IMidSurfaceThickness
{

    double Maximum { get; }
    double Minimum { get; }
    IFace GetSourceFace();
}
