using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.ThickenFeature;

public interface IThickenFeatures : IList<IThickenFeatures>
{
    IThickenFeature Item { get; }


    IThickenFeature _Add(object Faces, object Distance, PartFeatureExtentDirectionEnum ExtentDirection,
        PartFeatureOperationEnum Operation, bool AutomaticFaceChain, bool CreateVerticalSurfaces);

    IThickenFeature Add(object Faces, object Distance, PartFeatureExtentDirectionEnum ExtentDirection,
        PartFeatureOperationEnum Operation, bool AutomaticFaceChain, bool CreateVerticalSurfaces,
        bool AutomaticBlending);
}