using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IiFeatureVectorInput
{

    string Prompt { get; }
    string Name { get; }
    iFeatureEntityInputTypeEnum EntityType { get; }
    object LineInput { get; set; }
    bool FlipOption { get; set; }
}
