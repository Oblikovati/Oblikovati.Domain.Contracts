using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IOrdinateDimensions : IList<IOrdinateDimensions>
{

    int Count { get; }
    IOrdinateDimension Item { get; }
    IEnumerator GetEnumerator();
    IOrdinateDimension Add(IGeometryIntent Intent, IPoint2d TextOrigin, DimensionTypeEnum DimensionType, object DimensionStyle, object Layer);
}
