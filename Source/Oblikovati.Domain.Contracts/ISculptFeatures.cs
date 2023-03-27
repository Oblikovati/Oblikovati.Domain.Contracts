using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface ISculptFeatures : IList<ISculptFeatures>
{

    ISculptFeature Item { get; }
    int Count { get; }
    ISculptFeature _Add(IObjectCollection Surfaces, bool FillOperation);
    ISculptSurface CreateSculptSurface(object Surface, PartFeatureExtentDirectionEnum Direction);
    IEnumerator GetEnumerator();
    ISculptFeature Add(IObjectCollection Surfaces, PartFeatureOperationEnum Operation, object AffectedBody);
}
