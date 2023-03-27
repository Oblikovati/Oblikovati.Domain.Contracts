using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IBaselineDimensionSets : IList<IBaselineDimensionSets>
{

    IBaselineDimensionSet Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
    IBaselineDimensionSet Add(IObjectCollection GeometryIntents, IPoint2d PlacementPoint, DimensionTypeEnum DimensionType, object DimensionStyle, object Layer);
}
