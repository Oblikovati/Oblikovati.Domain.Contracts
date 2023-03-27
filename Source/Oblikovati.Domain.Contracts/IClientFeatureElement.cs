namespace Oblikovati.Domain.Contracts;

public interface IClientFeatureElement
{

    IClientFeatureDefinition Parent { get; }
    object Element { get; }
    bool BrowserVisible { get; set; }
    bool UserEditable { get; set; }
    bool HighlightWithFeature { get; set; }
    void Delete();
}
