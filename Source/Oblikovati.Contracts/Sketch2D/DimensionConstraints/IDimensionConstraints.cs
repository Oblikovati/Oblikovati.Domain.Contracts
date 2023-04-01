using Oblikovati.Contracts.Application.TransientGeometry;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Sketch2D.DimensionConstraints;

public interface IDimensionConstraints : IList<IDimensionConstraints>
{
    IDimensionConstraint Item { get; }


    IOffsetDimConstraint AddOffset(ISketchLine Line, ISketchEntity Entity, IPoint2d TextPoint, bool LinearDiameter,
        bool Driven);

    ITwoPointDistanceDimConstraint AddTwoPointDistance(ISketchPoint PointOne, ISketchPoint PointTwo,
        DimensionOrientationEnum Orientation, IPoint2d TextPoint, bool Driven);

    ITwoLineAngleDimConstraint AddTwoLineAngle(ISketchLine LineOne, ISketchLine LineTwo, IPoint2d TextPoint,
        bool Driven);

    IThreePointAngleDimConstraint AddThreePointAngle(ISketchPoint PointOne, ISketchPoint PointTwo,
        ISketchPoint PointThree, IPoint2d TextPoint, bool Driven);

    IDiameterDimConstraint AddDiameter(ISketchEntity Entity, IPoint2d TextPoint, bool Driven);
    IRadiusDimConstraint AddRadius(ISketchEntity Entity, IPoint2d TextPoint, bool Driven);
    IArcLengthDimConstraint AddArcLength(ISketchEntity Entity, IPoint2d TextPoint, bool Driven);

    ITangentDistanceDimConstraint AddTangentDistance(ISketchEntity EntityOne, ISketchEntity EntityTwo,
        IPoint2d ProximityPointOne, IPoint2d ProximityPointTwo, IPoint2d TextPoint, bool LinearDiameter, bool Driven);

    IEllipseRadiusDimConstraint AddEllipseRadius(ISketchEntity Entity, bool MajorRadius, IPoint2d TextPoint,
        object PositiveSide, bool Driven);

    IOffsetSplineDimConstraint AddOffsetSpline(ISketchOffsetSpline Line, IPoint2d TextPoint, bool Driven);
}