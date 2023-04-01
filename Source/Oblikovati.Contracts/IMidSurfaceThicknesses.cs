namespace Oblikovati.Contracts;

public interface IMidSurfaceThicknesses : IList<IMidSurfaceThicknesses>
{
    IMidSurfaceThickness Item { get; }
}