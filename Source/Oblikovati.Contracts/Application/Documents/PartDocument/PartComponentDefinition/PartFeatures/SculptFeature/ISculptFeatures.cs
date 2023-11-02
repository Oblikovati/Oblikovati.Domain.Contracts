using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Enums;
using Oblikovati.Contracts.NotClassified;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.SculptFeature;

public interface ISculptFeatures : IList<ISculptFeatures>
{
    ISculptFeature Item { get; }

    ISculptFeature _Add(IObjectCollection Surfaces, bool FillOperation);
    ISculptSurface CreateSculptSurface(object Surface, PartFeatureExtentDirectionEnum Direction);

    ISculptFeature Add(IObjectCollection Surfaces, PartFeatureOperationEnum Operation, object AffectedBody);
}