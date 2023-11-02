using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition;
using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.iFeature;
using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.ReferenceComponents.DerivedAliasComponents;
using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.ReferenceComponents.DerivedAssemblyComponents;
using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.ReferenceComponents.DerivedFutureAssemblyComponents;
using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.ReferenceComponents.DerivedFuturePartComponents;
using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.ReferenceComponents.DerivedPartComponents;

namespace Oblikovati.Contracts.NotClassified;

public interface IReferenceComponents
{
    IDerivedPartComponents DerivedPartComponents { get; }
    IDerivedAssemblyComponents DerivedAssemblyComponents { get; }
    IiFeatureTemplateDescriptors iFeatureTemplateDescriptors { get; }
    IiFeatureComponents iFeatureComponents { get; }
    IDerivedAliasComponents DerivedAliasComponents { get; }
    IImportedComponents ImportedComponents { get; }
    IDerivedFuturePartComponents DerivedFuturePartComponents { get; }
    IDerivedFutureAssemblyComponents DerivedFutureAssemblyComponents { get; }
    IShrinkwrapComponents ShrinkwrapComponents { get; }
}