namespace Oblikovati.Contracts;

public interface ISurfaceBodies : IList<ISurfaceBodies>
{
    ISurfaceBody Item { get; }
}