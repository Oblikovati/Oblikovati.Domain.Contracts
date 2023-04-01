using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.ChangeManager;

public interface IChangeDefinitionObject
{
    IChangeManager Parent { get; }
    string InternalName { get; }
    string CommandName { get; }
    string ClientId { get; }
    CommandTypesEnum ChangeType { get; set; }
    void Delete();
    IChangeProcessor CreateChangeProcessor();
}