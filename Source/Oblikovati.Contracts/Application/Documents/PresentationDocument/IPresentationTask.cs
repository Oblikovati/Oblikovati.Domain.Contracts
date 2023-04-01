namespace Oblikovati.Contracts.Application.Documents.PresentationDocument;

public interface IPresentationTask
{
    string Name { get; }
    IPresentationSequences Sequences { get; }
}