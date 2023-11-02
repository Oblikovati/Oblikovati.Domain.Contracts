using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.SweepFeature;

namespace Oblikovati.Contracts.NotClassified;

public interface IPathAndGuideSurfaceSweepDef
{
    ISweepFeature Parent { get; }
    object GuideSurface { get; set; }
}