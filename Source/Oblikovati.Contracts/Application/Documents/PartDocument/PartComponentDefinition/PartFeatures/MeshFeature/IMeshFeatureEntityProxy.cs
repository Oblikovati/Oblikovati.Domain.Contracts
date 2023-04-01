using Oblikovati.Contracts.Application.Documents.AssemblyDocument.AssemblyComponentDefinition.ComponentOccurence;
using Oblikovati.Contracts.Attributes;
using Oblikovati.Contracts.Enums;
using Oblikovati.Contracts.GraphicsDataSets;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.MeshFeature;

public interface IMeshFeatureEntityProxy
{
    IAttributeSets AttributeSets { get; }
    IMeshFeature Parent { get; }
    IGraphicsCoordinateSet CoordinateSet { get; }
    IGraphicsIndexSet CoordinateIndexSet { get; }
    IGraphicsColorSet ColorSet { get; }
    IGraphicsIndexSet ColorIndexSet { get; }
    IGraphicsNormalSet NormalSet { get; }
    IGraphicsIndexSet NormalIndexSet { get; }
    ColorBindingEnum ColorBinding { get; }
    NormalBindingEnum NormalBinding { get; }
    IMeshFeatureEntity NativeObject { get; }
    IComponentOccurrence ContainingOccurrence { get; }
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
}