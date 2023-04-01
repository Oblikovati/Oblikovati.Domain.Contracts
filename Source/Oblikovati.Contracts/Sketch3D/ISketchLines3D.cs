namespace Oblikovati.Contracts.Sketch3D;

public interface ISketchLines3D : IList<ISketchLines3D>
{
    ISketchLine3D Item { get; }

    ISketchLine3D AddByTwoPoints(object StartPoint, object EndPoint, bool UseAutoBend, object BendRadius);
}