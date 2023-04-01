namespace Oblikovati.Contracts;

public interface IRevolvedFaceWorkAxisDef
{
    IWorkAxis Parent { get; }
    IFace Face { get; }
}