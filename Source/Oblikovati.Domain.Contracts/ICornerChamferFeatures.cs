namespace Oblikovati.Domain.Contracts;

public interface ICornerChamferFeatures : IList<ICornerChamferFeatures>
{

    ICornerChamferFeature Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
    ICornerChamferFeature Add(ICornerChamferDefinition CornerChamferDefinition);
    ICornerChamferDefinition CreateCornerChamferDefinition(object CornerEdges, object Distance);
}
