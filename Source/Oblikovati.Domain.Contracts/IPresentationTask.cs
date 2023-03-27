namespace Oblikovati.Domain.Contracts;

public interface IPresentationTask
{


    string Name { get; }
    IPresentationSequences Sequences { get; }
}
