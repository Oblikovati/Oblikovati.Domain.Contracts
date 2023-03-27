namespace Oblikovati.Domain.Contracts;

public interface ISketchControlPointSplines3D : IList<ISketchControlPointSplines3D>
{

    int Count { get; }
    ISketchControlPointSpline3D Item { get; }
    IEnumerator GetEnumerator();
    ISketchControlPointSpline3D Add(IObjectCollection ControlPoints);
}
