using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IDocumentInterests : IList<IDocumentInterests>
{

    int Count { get; }
    IDocumentInterest Item { get; }
    IEnumerator GetEnumerator();
    bool HasInterest(string ClientIdOrName);
    IDocumentInterest Add(string ClientId, string Name, DocumentInterestTypeEnum InterestType, int DataVersion, object ClientData);
}
