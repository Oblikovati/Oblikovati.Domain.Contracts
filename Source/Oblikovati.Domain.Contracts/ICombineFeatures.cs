using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface ICombineFeatures : IList<ICombineFeatures>
{

    ICombineFeature Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
    ICombineFeature Add(ISurfaceBody BaseBody, IObjectCollection ToolBodies, PartFeatureOperationEnum Operation, bool KeepToolBodies);
}
