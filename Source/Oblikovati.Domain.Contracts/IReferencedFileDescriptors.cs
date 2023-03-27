namespace Oblikovati.Domain.Contracts;

public interface IReferencedFileDescriptors : IList<IReferencedFileDescriptors>
{

    IReferencedFileDescriptor Item { get; }
    IReferencedFileDescriptor ItemByName(string name);
    int Count { get; }
    IEnumerator GetEnumerator();
}
