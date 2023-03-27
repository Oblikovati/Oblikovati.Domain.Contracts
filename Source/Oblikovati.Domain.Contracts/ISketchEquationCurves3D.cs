using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface ISketchEquationCurves3D : IList<ISketchEquationCurves3D>
{

    int Count { get; }
    ISketchEquationCurve3D Item { get; }
    IEnumerator GetEnumerator();
    ISketchEquationCurve3D Add(CoordinateSystemTypeEnum CoordinateSystemType, string XValueOrRadius, string YValueOrTheta, string ZValueOrPhi, object MinValue, object MaxValue);
    bool IsValidExpression(string Expression, object Unit);
}
