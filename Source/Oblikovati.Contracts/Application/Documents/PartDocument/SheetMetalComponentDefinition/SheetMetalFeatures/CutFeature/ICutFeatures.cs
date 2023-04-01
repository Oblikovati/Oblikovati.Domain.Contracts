using Oblikovati.Contracts.Sketch2D.Profiles;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.SheetMetalComponentDefinition.SheetMetalFeatures.
    CutFeature;

public interface ICutFeatures : IList<ICutFeatures>
{
    ICutFeature Item { get; }


    ICutFeature Add(ICutDefinition CutDefinition);
    ICutDefinition CreateCutDefinition(IProfile Profile);
}