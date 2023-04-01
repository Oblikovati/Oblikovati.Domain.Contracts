namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition;

public interface IiFeatureTemplateDescriptors : IList<IiFeatureTemplateDescriptors>
{
    IiFeatureTemplateDescriptor Item { get; }
}