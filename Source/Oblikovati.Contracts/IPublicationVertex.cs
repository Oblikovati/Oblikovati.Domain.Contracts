namespace Oblikovati.Contracts;

public interface IPublicationVertex
{
    IPublicationBody Parent { get; }
    IPublicationEdgesEnumerator Edges { get; }
    IPublicationFacesEnumerator Faces { get; }
    IPublicationComponent Component { get; }
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
}