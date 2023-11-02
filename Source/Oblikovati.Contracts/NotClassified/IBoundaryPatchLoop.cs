using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.NotClassified;

public interface IBoundaryPatchLoop
{
    object BoundaryPath { get; set; }
    BoundaryPatchConditionEnum GetBoundaryCondition(object BoundaryPathEntity);
    void SetBoundaryCondition(object BoundaryPathEntity, BoundaryPatchConditionEnum BoundaryPathCondition);
    void Delete();
    object GetBoundaryTangentWeight(object BoundaryPathEntity);
    void SetBoundaryTangentWeight(object BoundaryPathEntity, object BoundaryPathTangentWeight);
}