namespace Oblikovati.Contracts.Sketch3D;

public interface ISketchEllipses3D : IList<ISketchEllipses3D>
{
    ISketchEllipse3D Item { get; }
}