namespace Oblikovati.Domain.Contracts;

public interface ICoreCavityFeatures : IList<ICoreCavityFeatures>
{

    ICoreCavityFeature Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
    ICoreCavityFeature Add(ICoreCavityDefinition Definition);
    ICoreCavityDefinition CreateDefinition(ISurfaceBody PartBody, ISurfaceBody WorkpieceBody, IObjectCollection RunoffSurfaces, IUnitVector PullDirection);
}
