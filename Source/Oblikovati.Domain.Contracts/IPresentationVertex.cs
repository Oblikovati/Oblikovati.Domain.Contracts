namespace Oblikovati.Domain.Contracts;

public interface IPresentationVertex
{

    IPresentationEdgesEnumerator Edges { get; }
    IPresentationFacesEnumerator Faces { get; }
    IPresentationBody Parent { get; }
}
