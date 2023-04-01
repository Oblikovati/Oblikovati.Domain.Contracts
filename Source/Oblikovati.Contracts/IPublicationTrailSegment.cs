namespace Oblikovati.Contracts;

public interface IPublicationTrailSegment
{
    IPublicationTrail Parent { get; }
    IPublicationTweakPath PublicationTweakPath { get; }
    object Geometry { get; }
    IGeometryIntent Origin { get; }
    bool Visible { get; set; }
    void Delete();
}