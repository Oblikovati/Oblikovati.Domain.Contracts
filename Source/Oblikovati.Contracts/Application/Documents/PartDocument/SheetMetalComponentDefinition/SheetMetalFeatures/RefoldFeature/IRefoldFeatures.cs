using Oblikovati.Contracts.NotClassified;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.SheetMetalComponentDefinition.SheetMetalFeatures.
    RefoldFeature;

public interface IRefoldFeatures : IList<IRefoldFeatures>
{
    IRefoldFeature Item { get; }


    IRefoldFeature Add(IFace StationaryFace, object Bends, object Sketches);
}