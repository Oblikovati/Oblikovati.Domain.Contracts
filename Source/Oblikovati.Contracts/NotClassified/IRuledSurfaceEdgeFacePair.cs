namespace Oblikovati.Contracts.NotClassified;

public interface IRuledSurfaceEdgeFacePair
{
    void SetData(IEdge Edge, IFace Face);
    void GetData(out IEdge Edge, out IFace Face);
    void Delete();
}