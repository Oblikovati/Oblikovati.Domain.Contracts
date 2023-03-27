namespace Oblikovati.Domain.Contracts;

public interface IRevolvedFaceWorkAxisDef
{

    IWorkAxis Parent { get; }
    IFace Face { get; }
}
