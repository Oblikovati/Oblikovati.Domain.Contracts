namespace Oblikovati.Contracts.Sketch2D.GeometricConstraints;

public interface IGeometricConstraints : IList<IGeometricConstraints>
{
    IGeometricConstraint Item { get; }


    ICoincidentConstraint AddCoincident(ISketchEntity EntityOne, ISketchEntity EntityTwo);

    ICollinearConstraint AddCollinear(ISketchEntity EntityOne, ISketchEntity EntityTwo, bool UseEllipseOneMajorAxis,
        bool UseEllipseTwoMajorAxis);

    IConcentricConstraint AddConcentric(ISketchEntity EntityOne, ISketchEntity EntityTwo);
    IEqualLengthConstraint AddEqualLength(ISketchLine LineOne, ISketchLine LineTwo);
    IEqualRadiusConstraint AddEqualRadius(ISketchEntity EntityOne, ISketchEntity EntityTwo);
    IGroundConstraint AddGround(ISketchEntity Entity);
    IHorizontalConstraint AddHorizontal(ISketchEntity Entity, bool UseEllipseMajorAxis);
    IHorizontalAlignConstraint AddHorizontalAlign(ISketchPoint PointOne, ISketchPoint PointTwo);
    IMidpointConstraint AddMidpoint(ISketchPoint Point, ISketchLine Line);

    IParallelConstraint AddParallel(ISketchEntity EntityOne, ISketchEntity EntityTwo, bool UseEllipseOneMajorAxis,
        bool UseEllipseTwoMajorAxis);

    IPerpendicularConstraint AddPerpendicular(ISketchEntity EntityOne, ISketchEntity EntityTwo,
        bool UseEllipseOneMajorAxis, bool UseEllipseTwoMajorAxis);

    ISymmetryConstraint AddSymmetry(ISketchEntity EntityOne, ISketchEntity EntityTwo, ISketchLine SymmetryAxis);
    ITangentSketchConstraint _AddTangent(ISketchEntity EntityOne, ISketchEntity EntityTwo);
    ITangentSketchConstraint AddTangent(ISketchEntity EntityOne, ISketchEntity EntityTwo, object ProximityPoint);
    IVerticalConstraint AddVertical(ISketchEntity Entity, bool UseEllipseMajorAxis);
    IVerticalAlignConstraint AddVerticalAlign(ISketchPoint PointOne, ISketchPoint PointTwo);
    ISmoothConstraint AddSmooth(ISketchEntity EntityOne, ISketchEntity EntityTwo, object ProximityPoint);
    IMidpointConstraint AddMidPointToArc(ISketchPoint Point, ISketchArc Arc);
}