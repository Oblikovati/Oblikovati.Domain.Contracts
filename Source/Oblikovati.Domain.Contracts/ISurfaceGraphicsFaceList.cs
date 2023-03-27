namespace Oblikovati.Domain.Contracts;

public interface ISurfaceGraphicsFaceList : IList<ISurfaceGraphicsFaceList>
{

    int Count { get; }
    ISurfaceGraphicsFace Item { get; }
    IEnumerator GetEnumerator();
    void Add(object Faces);
    void Remove(int Index);
    void Clear();
}
