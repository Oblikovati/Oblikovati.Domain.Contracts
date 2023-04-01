namespace Oblikovati.Contracts.Sketch3D;

public interface ISketches3D : IList<ISketches3D>
{
    ISketch3D Item { get; }


    ISketch3D Add();
}