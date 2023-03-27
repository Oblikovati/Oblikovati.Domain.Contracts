namespace Oblikovati.Domain.Contracts;

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
