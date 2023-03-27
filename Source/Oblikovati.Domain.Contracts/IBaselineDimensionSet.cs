using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IBaselineDimensionSet
{

    ISheet Parent { get; }
    IAttributeSets AttributeSets { get; }
    DimensionTypeEnum DimensionType { get; }
    ILayer Layer { get; set; }
    IGeneralDimensionsEnumerator Members { get; }
    IGeometryIntent Origin { get; set; }
    int Precision { get; set; }
    IDimensionStyle Style { get; set; }
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    ILinearGeneralDimension AddMember(object DimensionOrGeometry);
    void ArrangeText();
    void Delete();
    void DetachMember(ILinearGeneralDimension Member);
}
