namespace Oblikovati.Domain.Contracts;

public interface IPresentationTasks
{

    int Count { get; }
    IPresentationTask Item { get; }
    IPresentationTask ItemById { get; }
    int NextId { get; }
}
