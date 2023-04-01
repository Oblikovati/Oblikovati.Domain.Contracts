using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.TransientGeometry;

public interface IBSplineCurveDefinition
{
    SplineFitMethodEnum FitMethod { get; set; }
    double Length { get; set; }
    bool FixedLength { get; set; }
    void AddPoint(IPoint Point, double Weight, object Tangent);
}