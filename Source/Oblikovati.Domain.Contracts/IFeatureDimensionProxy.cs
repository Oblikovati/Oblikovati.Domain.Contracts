using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IFeatureDimensionProxy
{

    IPartFeature Parent { get; }
    IParameter Parameter { get; }
    IPoint TextPoint { get; }
    IObjectCollection AnchorPoints { get; }
    FeatureDimensionTypeEnum DimensionType { get; }
    IAttributeSets AttributeSets { get; }
    IFeatureDimension NativeObject { get; }
    IComponentOccurrence ContainingOccurrence { get; }
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
}
