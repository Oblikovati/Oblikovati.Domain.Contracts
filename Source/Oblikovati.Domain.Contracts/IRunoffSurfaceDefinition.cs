namespace Oblikovati.Domain.Contracts;

public interface IRunoffSurfaceDefinition
{
    int AddExtrusionPiece(IObjectCollection EdgeUses, IUnitVector Direction);
    int AddRadiatePiece(object EdgeUse, IObjectCollection RulingPoints, IObjectCollection RulingVectors);
    int AddSurfaceExtensionPiece(object EdgeUse);
    int AddCornerPiece(IVertex Corner, IUnitVector StartVector, IUnitVector EndVector);
    ISurfaceBody CreateSingleRunoffPiece(int Index);
    ISurfaceBody CreateRunoff();
    int AddTangentExtensionPiece(IObjectCollection EdgeUses);
}
