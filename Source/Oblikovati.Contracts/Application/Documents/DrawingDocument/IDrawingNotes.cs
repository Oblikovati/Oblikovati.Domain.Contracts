using Oblikovati.Contracts.Application.Documents.PartDocument.SheetMetalComponentDefinition.SheetMetalFeatures.
    BendFeature;
using Oblikovati.Contracts.Leaders;
using Oblikovati.Contracts.NotClassified;

namespace Oblikovati.Contracts.Application.Documents.DrawingDocument;

public interface IDrawingNotes : IList<IDrawingNotes>
{
    IDrawingNote Item { get; }

    IGeneralNotes GeneralNotes { get; }
    ILeaderNotes LeaderNotes { get; }
    IChamferNotes ChamferNotes { get; }
    IBendNotes BendNotes { get; }
    IPunchNotes PunchNotes { get; }
    IHoleThreadNotes HoleThreadNotes { get; }
}