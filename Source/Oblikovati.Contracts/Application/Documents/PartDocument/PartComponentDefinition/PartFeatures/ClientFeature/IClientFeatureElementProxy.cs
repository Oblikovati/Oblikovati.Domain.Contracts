using Oblikovati.Contracts.Application.Documents.AssemblyDocument.AssemblyComponentDefinition.ComponentOccurence;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.ClientFeature;

public interface IClientFeatureElementProxy
{
    IClientFeatureDefinition Parent { get; }
    object Element { get; }
    bool BrowserVisible { get; set; }
    bool UserEditable { get; set; }
    bool HighlightWithFeature { get; set; }
    IClientFeatureElement NativeObject { get; }
    IComponentOccurrence ContainingOccurrence { get; }
    void Delete();
}