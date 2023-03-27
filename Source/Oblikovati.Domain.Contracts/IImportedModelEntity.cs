using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IImportedModelEntity
{

    IImportedModelEntities SubEntities { get; }
    ImportedModelEntityTypeEnum EntityType { get; }
    string Name { get; }
    IImportedComponentDefinition Parent { get; }
    IImportedModelEntity ParentEntity { get; }
    ImportedModelEntityStatusEnum ImportedStatus { get; set; }
}
