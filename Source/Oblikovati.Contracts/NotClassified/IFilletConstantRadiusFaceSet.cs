using Oblikovati.Contracts.Application.TransientGeometry;
using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Parameters;

namespace Oblikovati.Contracts.NotClassified;

public interface IFilletConstantRadiusFaceSet
{
    IFaceCollection FacesOne { get; }
    IFaceCollection FacesTwo { get; }
    IParameter Radius { get; }
    bool IncludeTangentFaces { get; }
    IPoint BiasPoint { get; }
    bool FacesOneReverseDirection { get; }
    bool FacesTwoReverseDirection { get; }
}