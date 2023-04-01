namespace Oblikovati.Contracts.Sketch3D;

public interface ISketchEllipticalArcs3D : IList<ISketchEllipticalArcs3D>
{
    ISketchEllipticalArc3D Item { get; }
}