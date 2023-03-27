namespace Oblikovati.Domain.Contracts;

public interface IIRxTransientGeometry
{
    IIRxMatrix CreateMatrix();
    IIRxMatrix2d CreateMatrix2d();
    IIRxBox CreateBox();
    IIRxBox2d CreateBox2d();
    IIRxPoint CreatePoint(double XCoord, double YCoord, double ZCoord);
    IIRxPoint2d CreatePoint2d(double XCoord, double YCoord);
    IIRxVector CreateVector(double XCoord, double YCoord, double ZCoord);
    IIRxVector2d CreateVector2d(double XCoord, double YCoord);
    IIRxUnitVector CreateUnitVector(double XCoord, double YCoord, double ZCoord);
    IIRxUnitVector2d CreateUnitVector2d(double XCoord, double YCoord);
    IIRxLine CreateLine();
    IIRxLine2d CreateLine2d();
    IIRxCircle CreateCircle();
    IIRxCircle2d CreateCircle2d();
    IIRxBSplineCurve CreateBSplineCurve(uint nOrder, uint nPoles, uint nKnots, uint nWeights, short bIsPeriodic, double pPoles, double pKnots, ref double pWeights);
    IIRxBSplineCurve2d CreateBSplineCurve2d(uint nOrder, uint nPoles, uint nKnots, uint nWeights, short bIsPeriodic, out double pPoles, out double pKnots, ref double pWeights);
    IIRxPlane CreatePlane();
    IIRxCylinder CreateCylinder();
    IIRxEllipticalCylinder CreateEllipticalCylinder();
    IIRxCone CreateCone();
    IIRxEllipticalCone CreateEllipticalCone();
    IIRxSphere CreateSphere();
    IIRxTorus CreateTorus();
    IIRxBSplineSurface CreateBSplineSurface(List<uint> pnOrder, uint nNumPolesUXV, uint nKnotsU, uint nKnotsV, uint nWeights, List<short> pbIsPeriodic, double pPoles, double pKnotsU, double pKnotsV, ref double pWeights);
}
