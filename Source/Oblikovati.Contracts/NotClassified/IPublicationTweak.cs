namespace Oblikovati.Contracts.NotClassified;

public interface IPublicationTweak
{
    IPublicationTweakDefinition Definition { get; set; }
    IPublicationTrailSegmentsEnumerator TrailSegments { get; }
    IPublicationTweakPaths Paths { get; }
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    void Delete();
}