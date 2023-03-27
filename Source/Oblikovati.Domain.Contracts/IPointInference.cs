using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IPointInference
{

    PointInferenceEnum InferenceType { get; }
    IObjectsEnumerator Entity { get; }
}
