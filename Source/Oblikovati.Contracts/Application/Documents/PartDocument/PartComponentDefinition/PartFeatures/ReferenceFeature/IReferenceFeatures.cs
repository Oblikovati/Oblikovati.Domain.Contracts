namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.ReferenceFeature;

public interface IReferenceFeatures : IList<IReferenceFeatures>
{
    IReferenceFeature Item { get; }
}