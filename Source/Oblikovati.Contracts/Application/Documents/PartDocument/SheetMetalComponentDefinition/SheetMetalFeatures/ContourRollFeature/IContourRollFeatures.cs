namespace Oblikovati.Contracts.Application.Documents.PartDocument.SheetMetalComponentDefinition.SheetMetalFeatures.
    ContourRollFeature;

public interface IContourRollFeatures : IList<IContourRollFeatures>
{
    IContourRollFeature Item { get; }
}