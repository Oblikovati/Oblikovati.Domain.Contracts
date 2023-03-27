using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IEmbossFeatures : IList<IEmbossFeatures>
{

    IEmbossFeature Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
    IEmbossFeature AddEmbossFromFace(IProfile Profile, object Distance, PartFeatureExtentDirectionEnum ExtentDirection, object TopFaceColor, object WrapFace);
    IEmbossFeature AddEngraveFromFace(IProfile Profile, object Distance, PartFeatureExtentDirectionEnum ExtentDirection, object TopFaceColor, object WrapFace);
    IEmbossFeature AddEmbossEngraveFromPlane(IProfile Profile, object Taper, PartFeatureExtentDirectionEnum ExtentDirection, object TopFaceColor);
}
