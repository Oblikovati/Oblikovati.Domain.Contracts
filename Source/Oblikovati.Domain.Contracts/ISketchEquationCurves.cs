using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface ISketchEquationCurves : IList<ISketchEquationCurves>
{

    int Count { get; }
    ISketchEquationCurve Item { get; }
    IEnumerator GetEnumerator();
    ISketchEquationCurve Add(CurveEquationTypeEnum EquationType, CoordinateSystemTypeEnum CoordinateSystemType, string XValueOrRadius, string YValueOrTheta, object MinValue, object MaxValue);
    bool IsValidExpression(string Expression, object Unit);
}
