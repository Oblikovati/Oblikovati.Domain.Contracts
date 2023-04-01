namespace Oblikovati.Contracts.Application.Documents.Document;

public interface IReferencedFileDescriptors : IList<IReferencedFileDescriptors>
{
    IReferencedFileDescriptor Item { get; }
    IReferencedFileDescriptor ItemByName(string name);
}