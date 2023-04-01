using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.PartFeature;
using Oblikovati.Contracts.Application.TransientObjects.Math;
using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Attributes;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.
    CircularPatternFeature;

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