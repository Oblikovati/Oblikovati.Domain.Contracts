namespace Oblikovati.Domain.Contracts;

public interface IFilletFullRoundSet
{

    IFaceCollection SideFacesOne { get; }
    IFaceCollection CenterFaces { get; }
    IFaceCollection SideFacesTwo { get; }
    bool IncludeTangentFaces { get; }
}
