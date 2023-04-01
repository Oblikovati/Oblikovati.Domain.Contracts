using Oblikovati.Contracts.Application.TransientObjects.Math;
using Oblikovati.Contracts.Application.TransientObjects.Utility;

namespace Oblikovati.Contracts.Application;

public interface IApplicationUtilities
{
    IMoldDefinition CreateMoldDefinition(ISurfaceBody PartBody, ISurfaceBody WorkpieceBody,
        IObjectCollection RunoffSurfaces, IUnitVector PullDirection, double Tolerance, object HolePatches,
        object Inserts);

    void CreateHolePatch(IEdgeCollection HoleEdges, bool PatchSpecifiedHoles);
    ISurfaceBody CreateHolePatch2(IObjectCollection EdgeUseLoop);
    ISurfaceBody CreateHolePatch3(IEdge Edge);
    IRunoffSurfaceDefinition CreateRunoffSurfaceDefinition(IBox RangeBox);

    void ExportMoldCoolingAnalysisData(IObjectCollection MoldBlocks, IObjectCollection BlockAttributes,
        IObjectCollection CoolingCurves, IObjectCollection CoolingAttributes, IObjectCollection RunnerCurves,
        IObjectCollection RunnerAttributes, string FileName);
}