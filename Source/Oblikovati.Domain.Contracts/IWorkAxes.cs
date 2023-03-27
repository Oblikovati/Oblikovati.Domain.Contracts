namespace Oblikovati.Domain.Contracts;

public interface IWorkAxes : IList<IWorkAxes>
{

    int Count { get; }
    IWorkAxis Item { get; }
    IComponentDefinition Parent { get; }
    IEnumerator GetEnumerator();
    IWorkAxis AddByLine(object Line, bool Construction);
    IWorkAxis AddByTwoPlanes(object Plane1, object Plane2, bool Construction);
    IWorkAxis AddByTwoPoints(object Point1, object Point2, bool Construction);
    IWorkAxis AddByRevolvedFace(IFace Face, bool Construction);
    IWorkAxis AddByPointAndPlane(object Point, object Plane, bool Construction);
    IWorkAxis AddByLineAndPlane(object Line, object Plane, bool Construction);
    IWorkAxis AddFixed(IPoint Point, IUnitVector Axis, bool Construction);
    IWorkAxis AddByAnalyticEdge(IEdge Edge, bool Construction);
    IWorkAxis AddByLineAndPoint(object Line, object Point, bool Construction);
    IWorkAxis AddByNormalToSurface(object Surface, object Point, bool Construction);
}
