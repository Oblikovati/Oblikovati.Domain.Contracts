namespace Oblikovati.Contracts.Application.Documents.Document;

public interface IReferencedOpaqueFileDescriptors : IList<IReferencedOpaqueFileDescriptors>
{
    IReferencedOpaqueFileDescriptor Item { get; }

    IReferencedOpaqueFileDescriptor ItemByName(string name);

    IReferencedOpaqueFileDescriptor Add(string FullFileName);
}