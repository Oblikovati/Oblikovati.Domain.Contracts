using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IOrdinateDimensionSet
{

    ISheet Parent { get; }
    IAttributeSets AttributeSets { get; }
    bool AlignMembers { get; set; }
    bool AllowBrokenLeaders { get; set; }
    bool ContinuousRunning { get; set; }
    DimensionTypeEnum DimensionType { get; }
    bool DirectionReversed { get; set; }
    ILayer Layer { get; set; }
    IOrdinateDimensionsEnumerator Members { get; }
    IOrdinateDimension OriginMember { get; set; }
    bool PositiveBothDirections { get; set; }
    int Precision { get; set; }
    bool ShowDirection { get; set; }
    IDimensionStyle Style { get; set; }
    ArrowheadTypeEnum OriginArrowheadType { get; set; }
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    IOrdinateDimension AddMember(IGeometryIntent GeometryIntent);
    void Delete();
}
