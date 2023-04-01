using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.CommandManager.InteractionEvents.MouseEvents;

public interface IPointInference
{
    PointInferenceEnum InferenceType { get; }
    IObjectsEnumerator Entity { get; }
}