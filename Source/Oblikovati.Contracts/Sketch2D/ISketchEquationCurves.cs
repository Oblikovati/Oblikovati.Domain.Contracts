using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Sketch2D;

public interface ISketchEquationCurves : IList<ISketchEquationCurves>
{
    ISketchEquationCurve Item { get; }

    ISketchEquationCurve Add(CurveEquationTypeEnum EquationType, CoordinateSystemTypeEnum CoordinateSystemType,
        string XValueOrRadius, string YValueOrTheta, object MinValue, object MaxValue);

    bool IsValidExpression(string Expression, object Unit);
}