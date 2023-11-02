using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Enums;
using Oblikovati.Contracts.Parameters;

namespace Oblikovati.Contracts.NotClassified;

public interface IFilletVariableRadiusEdgeSet : IList<IFilletVariableRadiusEdgeSet>
{
    IEdgeCollection Edges { get; }
    IFilletIntermediateRadius IntermediateRadiusItem { get; }
    int IntermediateRadiusCount { get; }
    IParameter StartRadius { get; }
    IParameter EndRadius { get; }
    ContinuityTypeEnum ContinuityType { get; set; }

    IFilletIntermediateRadius AddIntermediateRadius(IEdge Edge, object Radius, object PercentLength);
}