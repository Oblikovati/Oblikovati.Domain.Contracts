using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.PartFeature;
using Oblikovati.Contracts.Parameters;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.SheetMetalComponentDefinition.SheetMetalFeatures.
    CutFeature;

public interface ICutAcrossBendsExtent
{
    IPartFeature Parent { get; }
    IParameter Distance { get; }
}