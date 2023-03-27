namespace Oblikovati.Domain.Contracts;

public interface IHelicalCurveShapeDefinitionRows : IList<IHelicalCurveShapeDefinitionRows>
{

    int Count { get; }
    IHelicalCurveShapeDefinitionRow Item { get; }
    IEnumerator GetEnumerator();
    IHelicalCurveShapeDefinitionRow Add(object Diameter, object Pitch, object Revolution, object Height, object Index);
}
