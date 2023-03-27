using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IiFeatureInput
{

    string Prompt { get; }
    string Name { get; }
    iFeatureEntityInputTypeEnum EntityType { get; }
}
