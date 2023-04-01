using Oblikovati.Contracts.Application.TransientGeometry;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.Documents.DrawingDocument.Sheets.DrawingDimensions;

public interface IOrdinateDimensions : IList<IOrdinateDimensions>
{
    IOrdinateDimension Item { get; }

    IOrdinateDimension Add(IGeometryIntent Intent, IPoint2d TextOrigin, DimensionTypeEnum DimensionType,
        object DimensionStyle, object Layer);
}