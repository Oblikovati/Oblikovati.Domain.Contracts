namespace Oblikovati.Domain.Contracts;

public interface IiFeatureTemplateDescriptor
{

    IComponentDefinition Parent { get; }
    string LastKnownSourceFileName { get; }
    string InternalName { get; }
    void DelayReplaceAll(string NewSourceFilename);
}
