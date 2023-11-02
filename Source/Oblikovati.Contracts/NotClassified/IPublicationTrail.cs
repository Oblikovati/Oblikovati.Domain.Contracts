namespace Oblikovati.Contracts.NotClassified;

public interface IPublicationTrail
{
    IGeometryIntent Origin { get; }
    IPublicationComponent PublicationComponent { get; }
    IPublicationTrailSegments Segments { get; }
    bool Deleted { get; }
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    void Delete();
}