namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.ExtendFeature;

public interface IExtendFeatures : IList<IExtendFeatures>
{
    IExtendFeature Item { get; }
}