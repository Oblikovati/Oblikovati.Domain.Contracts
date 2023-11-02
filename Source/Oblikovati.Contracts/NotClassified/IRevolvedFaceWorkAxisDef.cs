namespace Oblikovati.Contracts.NotClassified;

public interface IRevolvedFaceWorkAxisDef
{
    IWorkAxis Parent { get; }
    IFace Face { get; }
}