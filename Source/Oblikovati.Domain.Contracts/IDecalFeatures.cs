namespace Oblikovati.Domain.Contracts;

public interface IDecalFeatures : IList<IDecalFeatures>
{

    IDecalFeature Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
    IDecalFeature Add(ISketchImage Image, IFace Face, bool WrapFace, bool ChainFaces);
}
