namespace Oblikovati.Domain.Contracts;

public interface ISurfaceBodies : IList<ISurfaceBodies>
{
    ISurfaceBody Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
}
