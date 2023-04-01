using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.TransientGeometry;

public interface IBSplineCurve2dDefinition
{
    SplineFitMethodEnum FitMethod { get; set; }
    void AddPoint(IPoint2d Point, double Weight, object Tangent);
}