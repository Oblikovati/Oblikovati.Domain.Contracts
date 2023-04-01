using Oblikovati.Contracts.Application.TransientGeometry;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Sketch3D.HelicalCurves;

public interface IHelicalCurves : IList<IHelicalCurves>
{
    IHelicalCurve Item { get; }

    IHelicalCurveConstantShapeDefinition CreateConstantShapeDefinition(
        HelicalShapeDefinitionTypeEnum ShapeDefinitionType, IPoint AxisStartPoint, IPoint AxisEndPoint,
        IPoint CurveStartPoint, object Diameter, object Pitch, object Revolution, object Height);

    IHelicalCurveVariableShapeDefinition CreateVariableShapeDefinition(
        HelicalShapeDefinitionTypeEnum ShapeDefinitionType, IPoint AxisStartPoint, IPoint AxisEndPoint,
        IPoint CurveStartPoint, object Diameter, object Pitch, object Revolution, object Height);

    IHelicalCurve Add(IHelicalCurveDefinition HelicalCurveDefinition);
}