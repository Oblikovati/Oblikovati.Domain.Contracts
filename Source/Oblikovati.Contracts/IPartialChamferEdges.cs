using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts;

public interface IPartialChamferEdges : IList<IPartialChamferEdges>
{
    IPartialChamferEdge Item { get; }
    PartialChamferDrivenDimensionTypeEnum DrivenDimensionType { get; set; }

    IPartialChamferEdge Add(object Edge, object Start, object End);
}