namespace Oblikovati.Domain.Contracts;

public interface ILineAndFaceWorkPointDef
{

    IWorkPoint Parent { get; }
    object Line { get; }
    IFace Face { get; }
    void GetData(out object Line, out IFace Face);
}
