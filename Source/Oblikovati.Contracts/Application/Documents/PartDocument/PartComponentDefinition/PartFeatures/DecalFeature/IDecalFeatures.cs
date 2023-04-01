using Oblikovati.Contracts.Sketch2D;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.DecalFeature;

public interface IDecalFeatures : IList<IDecalFeatures>
{
    IDecalFeature Item { get; }


    IDecalFeature Add(ISketchImage Image, IFace Face, bool WrapFace, bool ChainFaces);
}