namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.
    DirectEditFeature;

public interface IDirectEditFeatures : IList<IDirectEditFeatures>
{
    IDirectEditFeature Item { get; }
}