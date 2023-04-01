using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.SweepFeature;

namespace Oblikovati.Contracts.Unsorted;

public interface I_SweepDefinition
{
    ISweepFeature Parent { get; }
}