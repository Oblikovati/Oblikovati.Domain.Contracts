namespace Oblikovati.Domain.Contracts;

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
