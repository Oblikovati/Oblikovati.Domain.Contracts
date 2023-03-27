using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IFilletConstantRadiusEdgeSet
{

    IEdgeCollection Edges { get; }
    IParameter Radius { get; }
    bool AllFillets { get; }
    bool AllRounds { get; }
    ContinuityTypeEnum ContinuityType { get; set; }
    bool InvertedFillet { get; set; }
}
