using Oblikovati.Contracts.Application.TransientGeometry;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.NotClassified;

public interface IGeometryIntent
{
    object Geometry { get; }
    object Intent { get; }
    IntentTypeEnum IntentType { get; }
    IPoint2d PointOnSheet { get; }
    IPoint Point { get; }
}