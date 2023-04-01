using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.CoreCavityFeature;
using Oblikovati.Contracts.Application.TransientObjects.Math;
using Oblikovati.Contracts.Application.TransientObjects.Utility;

namespace Oblikovati.Contracts;

public interface ICoreCavityDefinition
{
    ICoreCavityFeature Parent { get; }
    ISurfaceBody PartBody { get; set; }
    IObjectCollection RunoffSurfaces { get; set; }
    IObjectCollection HolePatches { get; set; }
    IObjectCollection Inserts { get; set; }
    ISurfaceBody WorkpieceBody { get; set; }
    IUnitVector PullDirection { get; set; }
    double Tolerance { get; set; }
    ICoreCavityDefinition Copy();
}