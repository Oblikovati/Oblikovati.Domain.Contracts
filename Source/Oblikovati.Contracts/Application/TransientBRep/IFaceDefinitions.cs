namespace Oblikovati.Contracts.Application.TransientBRep;

public interface IFaceDefinitions : IList<IFaceDefinitions>
{
    IFaceDefinition Item { get; }


    IFaceDefinition Add(object SurfaceGeometry, bool IsParamReversed);
}