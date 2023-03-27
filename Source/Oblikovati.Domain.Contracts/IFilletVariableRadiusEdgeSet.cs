using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IFilletVariableRadiusEdgeSet : IList<IFilletVariableRadiusEdgeSet>
{

    IEdgeCollection Edges { get; }
    IFilletIntermediateRadius IntermediateRadiusItem { get; }
    int IntermediateRadiusCount { get; }
    IParameter StartRadius { get; }
    IParameter EndRadius { get; }
    ContinuityTypeEnum ContinuityType { get; set; }
    IEnumerator GetEnumerator();
    IFilletIntermediateRadius AddIntermediateRadius(IEdge Edge, object Radius, object PercentLength);
}
