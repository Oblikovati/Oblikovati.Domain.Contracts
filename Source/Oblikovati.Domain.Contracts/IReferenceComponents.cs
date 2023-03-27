namespace Oblikovati.Domain.Contracts;

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
