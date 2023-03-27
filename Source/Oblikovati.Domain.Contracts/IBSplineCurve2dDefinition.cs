using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IBSplineCurve2dDefinition
{
    SplineFitMethodEnum FitMethod { get; set; }
    void AddPoint(IPoint2d Point, double Weight, object Tangent);
}
