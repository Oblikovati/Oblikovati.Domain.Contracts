namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.
    CosmeticBendFeature;

public interface ICosmeticBendFeatures : IList<ICosmeticBendFeatures>
{
    ICosmeticBendFeature Item { get; }
}