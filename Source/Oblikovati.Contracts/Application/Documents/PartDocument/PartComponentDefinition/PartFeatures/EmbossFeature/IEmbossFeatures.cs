using Oblikovati.Contracts.Enums;
using Oblikovati.Contracts.Sketch2D.Profiles;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.EmbossFeature;

public interface IEmbossFeatures : IList<IEmbossFeatures>
{
    IEmbossFeature Item { get; }


    IEmbossFeature AddEmbossFromFace(IProfile Profile, object Distance, PartFeatureExtentDirectionEnum ExtentDirection,
        object TopFaceColor, object WrapFace);

    IEmbossFeature AddEngraveFromFace(IProfile Profile, object Distance, PartFeatureExtentDirectionEnum ExtentDirection,
        object TopFaceColor, object WrapFace);

    IEmbossFeature AddEmbossEngraveFromPlane(IProfile Profile, object Taper,
        PartFeatureExtentDirectionEnum ExtentDirection, object TopFaceColor);
}