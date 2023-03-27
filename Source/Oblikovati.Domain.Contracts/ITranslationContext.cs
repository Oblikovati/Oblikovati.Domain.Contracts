using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface ITranslationContext
{
    IOMechanismEnum Type { get; set; }
    object OpenIntoExisting { get; set; }
}
