namespace Oblikovati.Contracts.NotClassified;

public interface IMidSurfaceThicknesses : IList<IMidSurfaceThicknesses>
{
    IMidSurfaceThickness Item { get; }
}