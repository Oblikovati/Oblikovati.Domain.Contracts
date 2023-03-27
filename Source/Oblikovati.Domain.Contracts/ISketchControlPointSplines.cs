namespace Oblikovati.Domain.Contracts;

public interface ISketchControlPointSplines : IList<ISketchControlPointSplines>
{

    int Count { get; }
    ISketchControlPointSpline Item { get; }
    IEnumerator GetEnumerator();
    ISketchControlPointSpline Add(IObjectCollection ControlPoints);
}
