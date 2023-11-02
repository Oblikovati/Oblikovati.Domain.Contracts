namespace Oblikovati.Contracts.NotClassified;

public interface IFlatPatternPlate
{
    IFlatPattern Parent { get; }
    IFaces FrontFaces { get; }
    IFaces BackFaces { get; }
    bool IsRigid { get; }
    IFlatBendResult GetBendResult(bool FrontBendResult);
    IEdges GetBendExtentEdges(bool FrontFaceEdges);
}