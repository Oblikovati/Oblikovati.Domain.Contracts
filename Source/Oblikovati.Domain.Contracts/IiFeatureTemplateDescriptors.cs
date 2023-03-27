namespace Oblikovati.Domain.Contracts;

public interface IiFeatureTemplateDescriptors : IList<IiFeatureTemplateDescriptors>
{

    IiFeatureTemplateDescriptor Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
}
