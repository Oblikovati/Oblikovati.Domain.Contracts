using Oblikovati.Contracts.Application.TransientObjects.Math;
using Oblikovati.Contracts.NotClassified;

namespace Oblikovati.Contracts.Application.TransientGeometry;

public interface IEllipseFull2d
{
    IPoint2d Center { get; set; }
    IVector2d MajorAxisVector { get; set; }
    double MinorMajorRatio { get; set; }
    ICurve2dEvaluator Evaluator { get; }
    void GetEllipseFullData(ref List<double> Center, ref List<double> MajorAxis, out double MinorMajorRatio);
    void PutEllipseFullData(ref List<double> Center, ref List<double> MajorAxis, double MinorMajorRatio);
    IEllipseFull2d Copy();
}