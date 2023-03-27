using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IImportedRVTComponentDefinition
{

    IImportedComponent Parent { get; }
    string FullFileName { get; }
    ImportedAssemblyOrganizationTypeEnum ImportedAssemblyOrganizationType { get; set; }
    ImportedRevitLanguageTypeEnum ImportedLanguage { get; set; }
    string Imported3DView { get; set; }
    bool ReferenceModel { get; set; }
}
