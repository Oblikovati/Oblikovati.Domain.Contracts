using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.NotClassified;

public interface IImportedModelEntity
{
    IImportedModelEntities SubEntities { get; }
    ImportedModelEntityTypeEnum EntityType { get; }
    string Name { get; }
    IImportedComponentDefinition Parent { get; }
    IImportedModelEntity ParentEntity { get; }
    ImportedModelEntityStatusEnum ImportedStatus { get; set; }
}