using Oblikovati.Contracts.Application.TransientObjects.Math;
using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts;

public interface IPublicationTweaks : IList<IPublicationTweaks>
{
    IPublicationTweak Item { get; }
    IGeometryIntent TriadOrigin { get; set; }
    object TriadAlignment { get; set; }
    IMatrix TriadMatrix { get; }
    bool HasSelectedComponent { get; set; }
    bool SelectTriadOrigin { get; set; }
    bool SelectTriadAlignment { get; set; }
    bool Local { get; set; }
    bool SelectTrailAnchor { get; set; }
    bool SelectTrailSegment { get; set; }
    IObjectCollection TrailAnchors { get; }
    IObjectCollection TrailSegments { get; }
    bool FullTrailOperationMode { get; set; }
    bool SelectTweakPath { get; set; }
    IPublicationTweak TweakForPreview { get; set; }

    IPublicationTweak Add(IPublicationTweakDefinition Definition);

    IPublicationTweakDefinition CreateTweakDefinition(TweakTypeEnum TweakType, IObjectCollection PublicationComponents,
        object DirectionOrAxis, object Distance, object RotationAngle, object Transform, object DisplayTrails,
        object StartTime, object EndTime);

    void StartToMonitorTriadOriginSelection();
    void EndToMonitorTriadOriginSelection();
    void ClearTrailInfo();
    IPublicationTweak Add2(IPublicationTweakDefinition Definition, bool IsBrepUnattached);
}