using Oblikovati.Contracts.Application.TransientGeometry;
using Oblikovati.Contracts.Application.TransientObjects.Utility;

namespace Oblikovati.Contracts.Sketch3D.DimensionContraints3D;

public interface IDimensionConstraints3D : IList<IDimensionConstraints3D>
{
    IDimensionConstraint3D Item { get; }


    IPlane GetDimensionPlane(IObjectCollection Entities);

    ITwoLineAngleDimConstraint3D AddTwoLineAngle(ISketchLine3D LineOne, ISketchLine3D LineTwo, object TextPoint,
        bool Driven);

    IPointAndPlaneDistanceDimConstraint3D AddPointAndPlaneDistance(ISketchPoint3D Point, object Plane, object TextPoint,
        bool Driven);

    ITwoPointDistanceDimConstraint3D AddTwoPointDistance(object PointOne, object PointTwo, object TextPoint,
        bool Driven);

    ILineLengthDimConstraint3D AddLineLength(ISketchLine3D Line, object TextPoint, bool Driven);
    IRadiusDimConstraint3D AddRadius(ISketchEntity3D Entity, object TextPoint, bool Driven);
    ISplineLengthDimConstraint3D AddSplineLength(ISketchEntity3D SketchSpline, object TextPoint, bool Driven);
}