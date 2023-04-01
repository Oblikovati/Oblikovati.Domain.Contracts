using Oblikovati.Contracts.Sketch2D.Profiles;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.SheetMetalComponentDefinition.SheetMetalFeatures.
    FaceFeature;

public interface IFaceFeatures : IList<IFaceFeatures>
{
    IFaceFeature Item { get; }


    IFaceFeature Add(IFaceFeatureDefinition FaceFeatureDefinition);
    IFaceFeatureDefinition CreateFaceFeatureDefinition(IProfile Profile);
}