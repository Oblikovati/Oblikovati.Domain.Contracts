using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IOrdinateDimensionSets : IList<IOrdinateDimensionSets>
{

    int Count { get; }
    IOrdinateDimensionSet Item { get; }
    IEnumerator GetEnumerator();
    IOrdinateDimensionSet Add(IObjectCollection GeometryIntents, IPoint2d PlacementPoint, DimensionTypeEnum DimensionType, object DimensionStyle, object Layer);
}
