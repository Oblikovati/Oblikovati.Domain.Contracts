using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IThickenFeatures : IList<IThickenFeatures>
{

    IThickenFeature Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
    IThickenFeature _Add(object Faces, object Distance, PartFeatureExtentDirectionEnum ExtentDirection, PartFeatureOperationEnum Operation, bool AutomaticFaceChain, bool CreateVerticalSurfaces);
    IThickenFeature Add(object Faces, object Distance, PartFeatureExtentDirectionEnum ExtentDirection, PartFeatureOperationEnum Operation, bool AutomaticFaceChain, bool CreateVerticalSurfaces, bool AutomaticBlending);
}
