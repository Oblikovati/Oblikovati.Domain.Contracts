using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IFeatureDimension
{

    IPartFeature Parent { get; }
    IParameter Parameter { get; }
    IPoint TextPoint { get; }
    IObjectCollection AnchorPoints { get; }
    FeatureDimensionTypeEnum DimensionType { get; }
    IAttributeSets AttributeSets { get; }
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
}
