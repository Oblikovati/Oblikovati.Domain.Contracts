namespace Oblikovati.Domain.Contracts.Enums;

public enum HealthStatusEnum
{
    kUnknownHealth,
    kUpToDateHealth,
    kOutOfDateHealth,
    kDriverLostHealth,
    kInErrorHealth,
    kDeletedHealth,
    kCannotComputeHealth,
    kSuppressedHealth,
    kBeyondStopNodeHealth,
    kInconsistentHealth,
    kRedundantHealth,
    kNewlyAddedHealth,
    kInvalidLimitsHealth,
    kJointDOFLockedHealth,
}
