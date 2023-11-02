using Oblikovati.Contracts.Application.TransientGeometry;
using Oblikovati.Contracts.Application.TransientObjects.Math;
using Oblikovati.Contracts.ClientGraphics.ComponentDefinition;

namespace Oblikovati.Contracts.NotClassified;

public interface IWorkPlanes : IList<IWorkPlanes>
{
    IWorkPlane Item { get; }
    IComponentDefinition Parent { get; }


    IWorkPlane AddByThreePoints(object Point1, object Point2, object Point3, bool Construction);
    IWorkPlane AddByTwoLines(object Line1, object Line2, bool Construction);
    IWorkPlane AddByLineAndPoint(object Line, object Point, bool Construction);
    IWorkPlane AddByPlaneAndPoint(object Plane, object Point, bool Construction);
    IWorkPlane AddByLinePlaneAndAngle(object Line, object Plane, object Angle, bool Construction);
    IWorkPlane AddByPlaneAndOffset(object Plane, object Offset, bool Construction);
    IWorkPlane AddByPointAndTangent(object Point, IFace Face, bool Construction);
    IWorkPlane AddByLineAndTangent(object Line, IFace Face, IPoint ProximityPoint, bool Construction);
    IWorkPlane AddByPlaneAndTangent(object Plane, IFace Face, IPoint ProximityPoint, bool Construction);
    IWorkPlane AddByNormalToCurve(object CurveEntity, object Point, bool Construction);
    IWorkPlane _AddByTwoPlanes(object Plane1, object Plane2, bool Construction);
    IWorkPlane AddByTwoPlanes(object Plane1, object Plane2, object QuadrantPoint, bool Construction);
    IWorkPlane AddFixed(IPoint OriginPoint, IUnitVector XAxis, IUnitVector YAxis, bool Construction);
    IWorkPlane AddByTorusMidPlane(IFace Face, bool Construction);
}