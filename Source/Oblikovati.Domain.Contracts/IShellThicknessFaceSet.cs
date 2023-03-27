namespace Oblikovati.Domain.Contracts;

public interface IShellThicknessFaceSet
{

    IFaceCollection Faces { get; set; }
    IParameter Thickness { get; }
    void Delete();
}
