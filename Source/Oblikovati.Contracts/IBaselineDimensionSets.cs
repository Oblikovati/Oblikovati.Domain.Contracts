using Oblikovati.Contracts.Application.TransientGeometry;
using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts;

public interface IBaselineDimensionSets : IList<IBaselineDimensionSets>
{
    IBaselineDimensionSet Item { get; }


    IBaselineDimensionSet Add(IObjectCollection GeometryIntents, IPoint2d PlacementPoint,
        DimensionTypeEnum DimensionType, object DimensionStyle, object Layer);
}