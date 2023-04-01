namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.LightingStyles;

public interface ILightingStyles : IList<ILightingStyles>
{
    ILightingStyle Item { get; }

    ILightingStyle Add(string Name);
}