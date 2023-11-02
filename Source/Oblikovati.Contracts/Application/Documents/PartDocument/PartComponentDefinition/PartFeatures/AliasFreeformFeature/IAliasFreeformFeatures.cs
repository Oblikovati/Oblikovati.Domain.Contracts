using Oblikovati.Contracts.NotClassified;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.
    AliasFreeformFeature;

public interface IAliasFreeformFeatures : IList<IAliasFreeformFeatures>
{
    IAliasFreeformFeature Item { get; }


    IAliasFreeformFeature _Add(ISurfaceBody BaseBody);
}