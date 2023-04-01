using Oblikovati.Contracts.ClientGraphics.ComponentDefinition;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition;

public interface IiFeatureTemplateDescriptor
{
    IComponentDefinition Parent { get; }
    string LastKnownSourceFileName { get; }
    string InternalName { get; }
    void DelayReplaceAll(string NewSourceFilename);
}