using Oblikovati.Contracts.NotClassified;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.SheetMetalComponentDefinition.SheetMetalFeatures.
    ContourFlangeFeature;

public interface IContourFlangeFeatures : IList<IContourFlangeFeatures>
{
    IContourFlangeFeature Item { get; }


    IContourFlangeFeature Add(IContourFlangeDefinition ContourFlangeDefinition);
    IContourFlangeDefinition CreateContourFlangeDefinition(IPath Path, object Edges);
}