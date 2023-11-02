namespace Oblikovati.Contracts.NotClassified;

public interface ISurfaceBodies : IList<ISurfaceBodies>
{
    ISurfaceBody Item { get; }
}