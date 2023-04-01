namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.RestFeature;

public interface IRestFeatures : IList<IRestFeatures>
{
    IRestFeature Item { get; }
}