using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.Documents.Document;

public interface IDocumentInterests : IList<IDocumentInterests>
{
    IDocumentInterest Item { get; }

    bool HasInterest(string ClientIdOrName);

    IDocumentInterest Add(string ClientId, string Name, DocumentInterestTypeEnum InterestType, int DataVersion,
        object ClientData);
}