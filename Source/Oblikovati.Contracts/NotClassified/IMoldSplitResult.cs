using Oblikovati.Contracts.Application.TransientObjects.Utility;

namespace Oblikovati.Contracts.NotClassified;

public interface IMoldSplitResult
{
    int Status { get; }
    int NoteCount { get; }
    void _GetNote(int NoteIndex, out int NoteType, out IObjectsEnumerator Entities);

    void GetNote(int NoteIndex, out int NoteType, out IObjectsEnumerator Entities, out double Value,
        out string ErrorMessage);
}