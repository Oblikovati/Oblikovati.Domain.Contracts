namespace Oblikovati.Domain.Contracts;

public interface IDrawingNotes : IList<IDrawingNotes>
{

    IDrawingNote Item { get; }
    int Count { get; }
    IGeneralNotes GeneralNotes { get; }
    ILeaderNotes LeaderNotes { get; }
    IChamferNotes ChamferNotes { get; }
    IBendNotes BendNotes { get; }
    IPunchNotes PunchNotes { get; }
    IHoleThreadNotes HoleThreadNotes { get; }
    IEnumerator GetEnumerator();
}
