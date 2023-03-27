using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IReferencedOLEFileDescriptors : IList<IReferencedOLEFileDescriptors>
{

    IReferencedOLEFileDescriptor Item { get; }
    int Count { get; }
    IReferencedOLEFileDescriptor ItemByName(string name);
    IEnumerator GetEnumerator();
    IReferencedOLEFileDescriptor Add(string FullFileName, OLEDocumentTypeEnum Type);
}
