namespace Oblikovati.Domain.Contracts;

public interface ISketchImages : IList<ISketchImages>
{
    ISketchImage Item { get; }

    int Count { get; }
    IEnumerator GetEnumerator();
    ISketchImage Add(string FullFileName, IPoint2d Position, bool Link);
}
