namespace Oblikovati.Domain.Contracts;

public interface IWorkSurfaces : IList<IWorkSurfaces>
{

    IWorkSurface Item { get; }
    IComponentDefinition Parent { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
}
