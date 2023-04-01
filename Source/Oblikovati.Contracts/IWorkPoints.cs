using Oblikovati.Contracts.Application.TransientGeometry;
using Oblikovati.Contracts.ClientGraphics.ComponentDefinition;

namespace Oblikovati.Contracts;

public interface IWorkPoints : IList<IWorkPoints>
{
    IWorkPoint Item { get; }
    IComponentDefinition Parent { get; }

    IWorkPoint AddByThreePlanes(object Plane1, object Plane2, object Plane3, bool Construction);
    IWorkPoint AddByTwoLines(object Line1, object Line2, bool Construction);
    IWorkPoint AddByCurveAndEntity(object Curve, object Entity, object ProximityPoint, bool Construction);
    IWorkPoint AddByPoint(object Point, bool Construction);
    IWorkPoint AddByMidPoint(IEdge Edge, bool Construction);
    IWorkPoint AddFixed(IPoint Point, bool Construction);
    IWorkPoint AddByTorusCenterPoint(IFace Face, bool Construction);
    IWorkPoint AddBySphereCenterPoint(IFace Face, bool Construction);
    IWorkPoint AddAtCentroid(object Entities, bool Construction);
}