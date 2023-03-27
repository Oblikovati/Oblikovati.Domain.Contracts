using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IImportedGenericComponentDefinition
{

    IImportedComponent Parent { get; }
    string FullFileName { get; }
    bool ReferenceModel { get; set; }
    ImportedAssemblyOrganizationTypeEnum ImportedAssemblyOrganizationType { get; set; }
    ImportedSurfaceOrganizationTypeEnum ImportedSurfaceOrganizationType { get; set; }
    IImportedModelEntities ImportedModelEntities { get; }
    string SaveFilesLocation { get; set; }
    bool SaveFileNamesWithPrefix { get; set; }
    string SaveFileNamesPrefixOrSuffix { get; set; }
    ImportedModelGeometryTypeEnum ImportedModelGeometryTypes { get; set; }
    ImportedWorkGeometryTypeEnum ImportedWorkGeometryTypes { get; set; }
    ImportUnitsTypeEnum ImportUnitsType { get; set; }
    void ExcludeAll();
    void IncludeAll();
    IImportedGenericComponentDefinition Copy();
}
