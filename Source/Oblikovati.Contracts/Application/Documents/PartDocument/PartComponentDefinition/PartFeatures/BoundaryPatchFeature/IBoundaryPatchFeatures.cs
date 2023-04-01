namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.
    BoundaryPatchFeature;

public interface IBoundaryPatchFeatures : IList<IBoundaryPatchFeatures>
{
    IBoundaryPatchFeature Item { get; }

    IBoundaryPatchFeature Add(IBoundaryPatchDefinition Definition);
    IBoundaryPatchDefinition CreateBoundaryPatchDefinition();
}