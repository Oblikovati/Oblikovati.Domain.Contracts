using Oblikovati.Contracts.Application.TransientGeometry;
using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.Documents.DrawingDocument.Sheets.DrawingDimensions;

public interface IChainDimensionSets : IList<IChainDimensionSets>
{
    IChainDimensionSet Item { get; }


    IChainDimensionSet Add(IObjectCollection GeometryIntents, IPoint2d PlacementPoint, DimensionTypeEnum DimensionType,
        object DimensionStyle, object Layer);

    IChainDimensionSet AddUsingBaseDimension(IObjectCollection Dimensions, IObjectCollection GeometryIntents,
        object DimensionStyle, object Layer);
}