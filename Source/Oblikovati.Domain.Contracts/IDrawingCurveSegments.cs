namespace Oblikovati.Domain.Contracts;

public interface IDrawingCurveSegments : IList<IDrawingCurveSegments>
{

    IDrawingCurveSegment Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
}
