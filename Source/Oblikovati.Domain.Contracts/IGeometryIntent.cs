using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IGeometryIntent
{


    object Geometry { get; }
    object Intent { get; }
    IntentTypeEnum IntentType { get; }
    IPoint2d PointOnSheet { get; }
    IPoint Point { get; }
}
