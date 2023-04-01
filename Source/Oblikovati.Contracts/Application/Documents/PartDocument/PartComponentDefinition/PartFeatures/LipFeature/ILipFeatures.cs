namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.LipFeature;

public interface ILipFeatures : IList<ILipFeatures>
{
    ILipFeature Item { get; }
}