namespace Oblikovati.Domain.Contracts;

public interface IBoundaryPatchFeatures : IList<IBoundaryPatchFeatures>
{

    IBoundaryPatchFeature Item { get; }
    int Count { get; }
    IBoundaryPatchFeature Add(IBoundaryPatchDefinition Definition);
    IBoundaryPatchDefinition CreateBoundaryPatchDefinition();
    IEnumerator GetEnumerator();
}
