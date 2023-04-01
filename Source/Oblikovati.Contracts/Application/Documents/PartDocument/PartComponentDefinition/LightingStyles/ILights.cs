using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.LightingStyles;

public interface ILights : IList<ILights>
{
    ILight Item { get; }

    ILight Add(LightTypeEnum LightType);
}