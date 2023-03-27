namespace Oblikovati.Domain.Contracts;

public interface ISketchOffsetSplines : IList<ISketchOffsetSplines>
{

    int Count { get; }
    ISketchOffsetSpline Item { get; }
    IEnumerator GetEnumerator();
}
