using Oblikovati.Contracts.Application.TransientGeometry;
using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.Documents.DrawingDocument.Sheets.DrawingDimensions;

public interface IOrdinateDimensionSets : IList<IOrdinateDimensionSets>
{
    IOrdinateDimensionSet Item { get; }

    IOrdinateDimensionSet Add(IObjectCollection GeometryIntents, IPoint2d PlacementPoint,
        DimensionTypeEnum DimensionType, object DimensionStyle, object Layer);
}