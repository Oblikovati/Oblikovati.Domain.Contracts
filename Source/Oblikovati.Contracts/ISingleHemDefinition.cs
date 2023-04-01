using Oblikovati.Contracts.Application.Documents.PartDocument.SheetMetalComponentDefinition.SheetMetalFeatures.
    HemFeature;
using Oblikovati.Contracts.Parameters;

namespace Oblikovati.Contracts;

public interface ISingleHemDefinition
{
    IHemDefinition Parent { get; }
    IParameter Gap { get; }
    IParameter Length { get; }
}