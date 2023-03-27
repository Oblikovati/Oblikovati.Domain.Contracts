namespace Oblikovati.Domain.Contracts;

public interface IMidSurfaceThicknesses : IList<IMidSurfaceThicknesses>
{

    IMidSurfaceThickness Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
}
