namespace Oblikovati.Domain.Contracts;

public interface IPresentationScenes : IList<IPresentationScenes>
{

    int Count { get; }
    IPresentationScene Item { get; }
    IEnumerator GetEnumerator();
}
