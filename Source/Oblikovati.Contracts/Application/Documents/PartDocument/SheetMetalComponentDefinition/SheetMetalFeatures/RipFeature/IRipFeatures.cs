using Oblikovati.Contracts.NotClassified;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.SheetMetalComponentDefinition.SheetMetalFeatures.
    RipFeature;

public interface IRipFeatures : IList<IRipFeatures>
{
    IRipFeature Item { get; }


    IRipFeature Add(IRipDefinition RipDefinition);
    IRipDefinition CreateRipDefinition(IFace RipFace);
}