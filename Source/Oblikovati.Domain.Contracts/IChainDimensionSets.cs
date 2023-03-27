using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IChainDimensionSets : IList<IChainDimensionSets>
{

    IChainDimensionSet Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
    IChainDimensionSet Add(IObjectCollection GeometryIntents, IPoint2d PlacementPoint, DimensionTypeEnum DimensionType, object DimensionStyle, object Layer);
    IChainDimensionSet AddUsingBaseDimension(IObjectCollection Dimensions, IObjectCollection GeometryIntents, object DimensionStyle, object Layer);
}
