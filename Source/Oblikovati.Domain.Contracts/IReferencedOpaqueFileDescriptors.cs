namespace Oblikovati.Domain.Contracts;

public interface IReferencedOpaqueFileDescriptors : IList<IReferencedOpaqueFileDescriptors>
{

    IReferencedOpaqueFileDescriptor Item { get; }
    int Count { get; }
    IReferencedOpaqueFileDescriptor ItemByName(string name);
    IEnumerator GetEnumerator();
    IReferencedOpaqueFileDescriptor Add(string FullFileName);
}
