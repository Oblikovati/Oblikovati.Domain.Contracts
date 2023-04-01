using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Enums;
using Oblikovati.Contracts.Parameters;

namespace Oblikovati.Contracts;

public interface IFilletConstantRadiusEdgeSet
{
    IEdgeCollection Edges { get; }
    IParameter Radius { get; }
    bool AllFillets { get; }
    bool AllRounds { get; }
    ContinuityTypeEnum ContinuityType { get; set; }
    bool InvertedFillet { get; set; }
}