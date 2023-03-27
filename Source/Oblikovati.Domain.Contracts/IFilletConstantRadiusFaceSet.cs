namespace Oblikovati.Domain.Contracts;

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
