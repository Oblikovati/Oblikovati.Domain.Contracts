using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IChainDimensionSet
{

    IAttributeSets AttributeSets { get; }
    DimensionTypeEnum DimensionType { get; }
    ILayer Layer { get; set; }
    IGeneralDimensionsEnumerator Members { get; }
    ISheet Parent { get; }
    int Precision { get; set; }
    IDimensionStyle Style { get; set; }
    bool Locked { get; set; }
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    IGeneralDimensionsEnumerator AddMembers(object DimensionOrGeometry);
    void Delete();
    void MergeMembers(ILinearGeneralDimension MemberOne, ILinearGeneralDimension MemberTwo);
    void Arrange(ILinearGeneralDimension BaseDimension);
}
