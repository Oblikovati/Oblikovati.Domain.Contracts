using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.TransientObjects.Utility;

public interface ITranslationContext
{
    IOMechanismEnum Type { get; set; }
    object OpenIntoExisting { get; set; }
}