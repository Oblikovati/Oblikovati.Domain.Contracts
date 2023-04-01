using Oblikovati.Contracts.Application.TransientObjects.Utility;

namespace Oblikovati.Contracts;

public interface IFilletFullRoundSet
{
    IFaceCollection SideFacesOne { get; }
    IFaceCollection CenterFaces { get; }
    IFaceCollection SideFacesTwo { get; }
    bool IncludeTangentFaces { get; }
}