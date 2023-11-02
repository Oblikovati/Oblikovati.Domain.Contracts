using Oblikovati.Contracts.Application.Documents.PartDocument.SheetMetalComponentDefinition.SheetMetalFeatures.HemFeature;
using Oblikovati.Contracts.Parameters;

namespace Oblikovati.Contracts.NotClassified;

public interface ITeardropHemDefinition
{
    IHemDefinition Parent { get; }
    IParameter Radius { get; }
    IParameter Angle { get; }
}