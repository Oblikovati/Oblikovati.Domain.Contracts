using Oblikovati.Contracts.Application.TransientObjects.Math;
using Oblikovati.Contracts.Application.TransientObjects.Utility;

namespace Oblikovati.Contracts;

public interface IMoldDefinition
{
    ISurfaceBody Core { get; }
    ISurfaceBody Cavity { get; }
    IObjectCollection HolePatches { get; set; }
    IObjectCollection InsertBodies { get; set; }
    ISurfaceBody PartBody { get; set; }
    IUnitVector PullDirection { get; set; }
    IObjectCollection RunoffSurfaces { get; set; }
    double Tolerance { get; set; }
    ISurfaceBody WorkpieceBody { get; set; }
    IMoldSplitResult Separate();
}