using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IiFeatureWorkPlaneInput
{

    string Prompt { get; }
    string Name { get; }
    iFeatureEntityInputTypeEnum EntityType { get; }
    object PlaneInput { get; set; }
    bool FlipOption { get; set; }
}
