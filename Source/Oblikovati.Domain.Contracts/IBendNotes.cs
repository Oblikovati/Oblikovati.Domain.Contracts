namespace Oblikovati.Domain.Contracts;

public interface IBendNotes : IList<IBendNotes>
{

    int Count { get; }
    IBendNote Item { get; }
    IBendNote Add(IDrawingCurve BendEdge, object DimensionStyle);
    IEnumerator GetEnumerator();
}
