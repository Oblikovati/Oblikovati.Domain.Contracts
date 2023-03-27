namespace Oblikovati.Domain.Contracts;

public interface ISketchLines3D : IList<ISketchLines3D>
{

    int Count { get; }
    ISketchLine3D Item { get; }
    IEnumerator GetEnumerator();
    ISketchLine3D AddByTwoPoints(object StartPoint, object EndPoint, bool UseAutoBend, object BendRadius);
}
