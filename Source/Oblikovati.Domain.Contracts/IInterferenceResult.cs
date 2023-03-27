namespace Oblikovati.Domain.Contracts;

public interface IInterferenceResult
{
    IPoint Centroid { get; }
    IComponentOccurrence OccurrenceOne { get; }
    IComponentOccurrence OccurrenceTwo { get; }
    double Volume { get; }
    ISurfaceBody InterferenceBody { get; }
}
