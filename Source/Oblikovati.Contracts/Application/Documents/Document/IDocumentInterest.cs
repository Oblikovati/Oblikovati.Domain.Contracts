using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.Documents.Document;

public interface IDocumentInterest
{
    string ClientId { get; }
    string Name { get; }
    DocumentInterestTypeEnum InterestType { get; set; }
    int DataVersion { get; set; }
    string ClientData { get; set; }
    void Delete();
}