namespace Oblikovati.Contracts.Application.Documents.PresentationDocument;

public interface IPresentationVertex
{
    IPresentationEdgesEnumerator Edges { get; }
    IPresentationFacesEnumerator Faces { get; }
    IPresentationBody Parent { get; }
}