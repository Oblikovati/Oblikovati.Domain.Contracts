using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Sketch3D;

public interface ISketchEquationCurves3D : IList<ISketchEquationCurves3D>
{
    ISketchEquationCurve3D Item { get; }

    ISketchEquationCurve3D Add(CoordinateSystemTypeEnum CoordinateSystemType, string XValueOrRadius,
        string YValueOrTheta, string ZValueOrPhi, object MinValue, object MaxValue);

    bool IsValidExpression(string Expression, object Unit);
}