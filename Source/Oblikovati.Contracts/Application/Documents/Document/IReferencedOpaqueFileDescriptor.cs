namespace Oblikovati.Contracts.Application.Documents.Document;

public interface IReferencedOpaqueFileDescriptor
{
    string FullFileName { get; }
    void Delete();
}