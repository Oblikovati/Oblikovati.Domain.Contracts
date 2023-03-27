using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IHelicalCurves : IList<IHelicalCurves>
{

    int Count { get; }
    IHelicalCurve Item { get; }
    IEnumerator GetEnumerator();
    IHelicalCurveConstantShapeDefinition CreateConstantShapeDefinition(HelicalShapeDefinitionTypeEnum ShapeDefinitionType, IPoint AxisStartPoint, IPoint AxisEndPoint, IPoint CurveStartPoint, object Diameter, object Pitch, object Revolution, object Height);
    IHelicalCurveVariableShapeDefinition CreateVariableShapeDefinition(HelicalShapeDefinitionTypeEnum ShapeDefinitionType, IPoint AxisStartPoint, IPoint AxisEndPoint, IPoint CurveStartPoint, object Diameter, object Pitch, object Revolution, object Height);
    IHelicalCurve Add(IHelicalCurveDefinition HelicalCurveDefinition);
}
