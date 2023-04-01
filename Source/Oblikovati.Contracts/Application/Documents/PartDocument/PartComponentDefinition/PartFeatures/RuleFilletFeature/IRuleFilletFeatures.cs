namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.
    RuleFilletFeature;

public interface IRuleFilletFeatures : IList<IRuleFilletFeatures>
{
    IRuleFilletFeature Item { get; }
}