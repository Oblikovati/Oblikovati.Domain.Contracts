using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface ITriadEventsObject
{
    IInteractionEvents Parent { get; }
    TriadSegmentEnum DegreesOfFreedom { get; set; }
    IMatrix GlobalTransform { get; set; }
    bool MoveTriadOnly { get; set; }
    bool MoveTriadOnlyEnabled { get; set; }
    bool Enabled { get; set; }
    bool Repeat { get; set; }
    bool IsInRedefineMode { get; }
    void Reposition(TriadSegmentEnum TriadSegment, object AlignWith);
}
