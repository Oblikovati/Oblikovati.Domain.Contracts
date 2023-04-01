using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Parameters;

namespace Oblikovati.Contracts;

public interface IShellThicknessFaceSet
{
    IFaceCollection Faces { get; set; }
    IParameter Thickness { get; }
    void Delete();
}