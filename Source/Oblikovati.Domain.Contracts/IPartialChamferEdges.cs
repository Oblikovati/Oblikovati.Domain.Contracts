using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IPartialChamferEdges : IList<IPartialChamferEdges>
{

    int Count { get; }
    IPartialChamferEdge Item { get; }
    PartialChamferDrivenDimensionTypeEnum DrivenDimensionType { get; set; }
    IEnumerator GetEnumerator();
    IPartialChamferEdge Add(object Edge, object Start, object End);
}
