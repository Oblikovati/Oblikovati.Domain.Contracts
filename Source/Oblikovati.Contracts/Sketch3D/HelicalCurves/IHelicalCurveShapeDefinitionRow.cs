namespace Oblikovati.Contracts.Sketch3D.HelicalCurves;

public interface IHelicalCurveShapeDefinitionRow
{
    IHelicalCurveVariableShapeDefinition Parent { get; }
    int Index { get; }
    object Diameter { get; set; }
    object Pitch { get; set; }
    object Revolution { get; set; }
    object Height { get; set; }
    void Delete();
}