namespace Oblikovati.Domain.Contracts;

public interface IProjectToSurfaceCurves : IList<IProjectToSurfaceCurves>
{

    int Count { get; }
    IProjectToSurfaceCurve Item { get; }
    IEnumerator GetEnumerator();
    IProjectToSurfaceCurve Add(IObjectCollection Faces, IObjectCollection Curves, object ProjectionType, object ProjectDirection);
}
