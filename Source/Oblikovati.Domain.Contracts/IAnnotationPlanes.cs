namespace Oblikovati.Domain.Contracts;

public interface IAnnotationPlanes : IList<IAnnotationPlanes>
{
    int Count { get; }
    IAnnotationPlane Item { get; }
    IEnumerator GetEnumerator();
}
