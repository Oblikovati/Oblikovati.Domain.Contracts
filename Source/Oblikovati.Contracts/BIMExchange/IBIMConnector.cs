using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.BIMExchange;

public interface IBIMConnector
{
    IBIMComponent Parent { get; }
    IBIMConnectorDefinition Definition { get; }
    BIMConnectorDefinitionTypeEnum DefinitionType { get; }
    string Name { get; set; }
    bool Suppressed { get; set; }
    bool MissingAttachment { get; }
    void Delete();
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
}