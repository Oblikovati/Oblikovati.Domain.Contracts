using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IMeshFeatureEntity
{

    IAttributeSets AttributeSets { get; }
    IMeshFeature Parent { get; }
    IGraphicsCoordinateSet CoordinateSet { get; }
    IGraphicsIndexSet CoordinateIndexSet { get; }
    IGraphicsColorSet ColorSet { get; }
    IGraphicsIndexSet ColorIndexSet { get; }
    IGraphicsNormalSet NormalSet { get; }
    IGraphicsIndexSet NormalIndexSet { get; }
    ColorBindingEnum ColorBinding { get; }
    NormalBindingEnum NormalBinding { get; }
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
}
