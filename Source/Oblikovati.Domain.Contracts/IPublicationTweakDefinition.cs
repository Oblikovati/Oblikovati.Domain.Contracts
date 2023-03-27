using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IPublicationTweakDefinition
{

    IPublicationTweak Parent { get; }
    bool FullTrailOperationMode { get; set; }
    IObjectCollection TrailOriginsForAdd { get; set; }
    IObjectCollection TrailSegmentsForDelete { get; set; }
    IObjectCollection PublicationComponents { get; set; }
    object DirectionOrAxis { get; set; }
    object RotationAngle { get; set; }
    object Distance { get; set; }
    IGeometryIntent TriadOrigin { get; set; }
    object TriadXAxisAlignment { get; set; }
    bool Local { get; set; }
    TweakTypeEnum TweakType { get; }
    PublicationTweakTrailsDisplayEnum DisplayTrails { get; set; }
    IMatrix Transform { get; set; }
    IPublicationTweakDefinition Copy();
    void GetTimeRange(out double StartTime, out double EndTime);
    void SetTimeRange(double StartTime, double EndTime);
}
