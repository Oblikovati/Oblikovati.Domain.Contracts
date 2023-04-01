using Oblikovati.Contracts.Application.Documents.AssemblyDocument.AssemblyComponentDefinition.ComponentOccurence;
using Oblikovati.Contracts.Application.TransientGeometry;
using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Attributes;
using Oblikovati.Contracts.Enums;
using Oblikovati.Contracts.Parameters;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.PartFeature;

public interface IFeatureDimensionProxy
{
    IPartFeature Parent { get; }
    IParameter Parameter { get; }
    IPoint TextPoint { get; }
    IObjectCollection AnchorPoints { get; }
    FeatureDimensionTypeEnum DimensionType { get; }
    IAttributeSets AttributeSets { get; }
    IFeatureDimension NativeObject { get; }
    IComponentOccurrence ContainingOccurrence { get; }
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
}