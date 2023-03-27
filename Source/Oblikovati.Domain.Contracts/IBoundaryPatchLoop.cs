using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IBoundaryPatchLoop
{

    object BoundaryPath { get; set; }
    BoundaryPatchConditionEnum GetBoundaryCondition(object BoundaryPathEntity);
    void SetBoundaryCondition(object BoundaryPathEntity, BoundaryPatchConditionEnum BoundaryPathCondition);
    void Delete();
    object GetBoundaryTangentWeight(object BoundaryPathEntity);
    void SetBoundaryTangentWeight(object BoundaryPathEntity, object BoundaryPathTangentWeight);
}
