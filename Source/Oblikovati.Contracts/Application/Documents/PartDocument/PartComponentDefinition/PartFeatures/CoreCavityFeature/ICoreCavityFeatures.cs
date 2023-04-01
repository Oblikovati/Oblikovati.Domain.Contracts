using Oblikovati.Contracts.Application.TransientObjects.Math;
using Oblikovati.Contracts.Application.TransientObjects.Utility;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.
    CoreCavityFeature;

public interface ICoreCavityFeatures : IList<ICoreCavityFeatures>
{
    ICoreCavityFeature Item { get; }


    ICoreCavityFeature Add(ICoreCavityDefinition Definition);

    ICoreCavityDefinition CreateDefinition(ISurfaceBody PartBody, ISurfaceBody WorkpieceBody,
        IObjectCollection RunoffSurfaces, IUnitVector PullDirection);
}