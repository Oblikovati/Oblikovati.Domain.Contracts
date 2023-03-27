namespace Oblikovati.Domain.Contracts;

public interface IFeaturePatternElement
{

    IPartFeature Parent { get; }
    IAttributeSets AttributeSets { get; }
    int Index { get; }
    IFaces Faces { get; }
    bool Suppressed { get; set; }
    IMatrix Transform { get; }
    IObjectsEnumerator ResultFeatures { get; }
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
}
