namespace Oblikovati.Contracts.NotClassified;

public interface IPublicationFaceShell
{
    IPublicationBody Parent { get; }
    IPublicationEdgesEnumerator Edges { get; }
    IPublicationFacesEnumerator Faces { get; }
    IPublicationBody PublicationBody { get; }
    double Volume { get; }
    IPublicationComponent Component { get; }
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
}