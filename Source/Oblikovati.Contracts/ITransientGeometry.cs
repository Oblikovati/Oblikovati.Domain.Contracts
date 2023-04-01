using Oblikovati.Contracts.Application.TransientGeometry;
using Oblikovati.Contracts.Application.TransientObjects.Math;
using Oblikovati.Contracts.Application.TransientObjects.Utility;

namespace Oblikovati.Contracts;

public interface ITransientGeometry
{
    double PointTolerance { get; }
    IArc2d CreateArc2d(IPoint2d Center, double Radius, double StartAngle, double SweepAngle);
    IArc2d CreateArc2dByThreePoints(IPoint2d PointOne, IPoint2d PointTwo, IPoint2d PointThree);

    IArc3d CreateArc3d(IPoint Center, IUnitVector Normal, IUnitVector ReferenceVector, double Radius, double StartAngle,
        double SweepAngle);

    IArc3d CreateArc3dByThreePoints(IPoint PointOne, IPoint PointTwo, IPoint PointThree);
    IEllipseFull CreateEllipseFull(IPoint Center, IUnitVector Normal, IVector MajorAxisVector, double MinorMajorRatio);

    IEllipticalArc CreateEllipticalArc(IPoint Center, IUnitVector MajorAxis, IUnitVector MinorAxis, double MajorRadius,
        double MinorRadius, double StartAngle, double SweepAngle);

    IEllipticalArc2d CreateEllipticalArc2d(IPoint2d Center, IUnitVector2d MajorAxis, double MajorRadius,
        double MinorRadius, double StartAngle, double SweepAngle);

    IEllipseFull2d CreateEllipseFull2d(IPoint2d Center, IVector2d MajorAxisVector, double MinorMajorRatio);
    ILineSegment CreateLineSegment(IPoint StartPoint, IPoint EndPoint);
    ILineSegment2d CreateLineSegment2d(IPoint2d StartPoint, IPoint2d EndPoint);
    IMatrix CreateMatrix();
    IMatrix2d CreateMatrix2d();
    IBox CreateBox();
    IBox2d CreateBox2d();
    IPoint CreatePoint(double XCoord, double YCoord, double ZCoord);
    IPoint2d CreatePoint2d(double XCoord, double YCoord);
    IVector CreateVector(double XCoord, double YCoord, double ZCoord);
    IVector2d CreateVector2d(double XCoord, double YCoord);
    IUnitVector CreateUnitVector(double XCoord, double YCoord, double ZCoord);
    IUnitVector2d CreateUnitVector2d(double XCoord, double YCoord);
    ILine CreateLine(IPoint RootPoint, IVector Direction);
    ILine2d CreateLine2d(IPoint2d RootPoint, IUnitVector2d Direction);
    ICircle CreateCircle(IPoint Center, IUnitVector Normal, double Radius);
    ICircle CreateCircleByThreePoints(IPoint PointOne, IPoint PointTwo, IPoint PointThree);
    ICircle2d CreateCircle2d(IPoint2d Center, double Radius);
    ICircle2d CreateCircle2dByThreePoints(IPoint2d PointOne, IPoint2d PointTwo, IPoint2d PointThree);

    IBSplineCurve CreateBSplineCurve(int Order, ref List<double> Poles, ref List<double> Knots,
        ref List<double> Weights, bool IsPeriodic);

    IBSplineCurve2d CreateBSplineCurve2d(int Order, ref List<double> Poles, ref List<double> Knots,
        ref List<double> Weights, bool IsPeriodic);

    IPlane CreatePlane(IPoint RootPoint, IVector Normal);
    IPlane CreatePlaneByThreePoints(IPoint PointOne, IPoint PointTwo, IPoint PointThree);
    ICylinder CreateCylinder(IPoint RootPoint, IUnitVector Axis, double Radius);

    IEllipticalCylinder CreateEllipticalCylinder(IPoint BasePoint, IUnitVector AxisVector, IVector MajorAxisVector,
        double MinorMajorRatio);

    ICone CreateCone(IPoint RootPoint, IUnitVector Axis, double Radius, double HalfAngle, bool IsExpanding);

    IEllipticalCone CreateEllipticalCone(IPoint BasePoint, IUnitVector AxisVector, IVector MajorAxisVector,
        double MinorMajorRatio, double HalfAngle, bool IsExpanding);

    ISphere CreateSphere(IPoint CenterPoint, double Radius);
    ITorus CreateTorus(IPoint CenterPoint, IUnitVector AxisVector, double MajorRadius, double MinorRadius);

    IBSplineSurface CreateBSplineSurface(List<int> Order, List<double> Poles, List<double> KnotsU, List<double> KnotsV,
        List<double> Weights, List<bool> IsPeriodic);

    IBSplineCurve2dDefinition CreateBSplineCurve2dDefinition();
    IBSplineCurve2d CreateFittedBSplineCurve2d(IBSplineCurve2dDefinition Definition);
    IBSplineCurveDefinition CreateBSplineCurveDefinition();
    IBSplineCurve CreateFittedBSplineCurve(IBSplineCurveDefinition Definition);
    IPolyline3d CreatePolyline3d(object Points);
    IPolyline3d CreatePolyline3dFromCurve(object Curve, double Tolerance);
    IPolyline2d CreatePolyline2d(object Points);
    IPolyline2d CreatePolyline2dFromCurve(object Curve, double Tolerance);
    IObjectsEnumerator CurveCurveIntersection(object CurveOne, object CurveTwo, double Tolerance);
    IObjectsEnumerator CurveSurfaceIntersection(object Curve, object Surface, double Tolerance);
    IObjectsEnumerator SurfaceSurfaceIntersection(object SurfaceOne, object SurfaceTwo, double Tolerance);
    IPoint GetFarmostPoint(object Entity, IUnitVector Direction);
    IOrientedBox CreateOrientedBox(object CornerPoint, object DirectionOne, object DirectionTwo, object DirectionThree);
}