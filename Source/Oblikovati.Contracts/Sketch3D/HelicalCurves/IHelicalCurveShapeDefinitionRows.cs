namespace Oblikovati.Contracts.Sketch3D.HelicalCurves;

public interface IHelicalCurveShapeDefinitionRows : IList<IHelicalCurveShapeDefinitionRows>
{
    IHelicalCurveShapeDefinitionRow Item { get; }

    IHelicalCurveShapeDefinitionRow Add(object Diameter, object Pitch, object Revolution, object Height, object Index);
}