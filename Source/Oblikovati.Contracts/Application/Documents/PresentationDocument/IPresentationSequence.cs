using Oblikovati.Contracts.Application.TransientObjects.Utility;

namespace Oblikovati.Contracts.Application.Documents.PresentationDocument;

public interface IPresentationSequence
{
    string Name { get; }
    IPublicationComponentsEnumerator HiddenComponents { get; }
    int Id { get; }
    int Interval { get; }
    ICamera Camera { get; }
    bool IsCameraSaved { get; }
    IPresentationTweaks Tweaks { get; }
    void GetStartEndTime(out double StartTime, out double EndTime);
}