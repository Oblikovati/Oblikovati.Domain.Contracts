using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.Documents.Document;

public interface IReferencedOLEFileDescriptors : IList<IReferencedOLEFileDescriptors>
{
    IReferencedOLEFileDescriptor Item { get; }

    IReferencedOLEFileDescriptor ItemByName(string name);

    IReferencedOLEFileDescriptor Add(string FullFileName, OLEDocumentTypeEnum Type);
}