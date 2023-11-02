using Oblikovati.Contracts.NotClassified;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.SheetMetalComponentDefinition.SheetMetalFeatures.
    UnfoldFeature;

public interface IUnfoldFeatures : IList<IUnfoldFeatures>
{
    IUnfoldFeature Item { get; }
    IUnfoldFeature Add(IFace StationaryFace, object Bends, object Sketches);
}