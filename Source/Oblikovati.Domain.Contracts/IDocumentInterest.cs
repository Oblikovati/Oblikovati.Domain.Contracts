using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IDocumentInterest
{


    string ClientId { get; }
    string Name { get; }
    DocumentInterestTypeEnum InterestType { get; set; }
    int DataVersion { get; set; }
    string ClientData { get; set; }
    void Delete();
}
