using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IDSDegreeOfFreedom
{

    IDSJointDefinition Parent { get; }
    double InitialPosition { get; set; }
    double InitialVelocity { get; set; }
    bool IsMaxBoundsEnabled { get; set; }
    bool IsMinBoundsEnabled { get; set; }
    bool IsPositionLocked { get; set; }
    bool IsLoadEnabled { get; set; }
    bool IsVelocityComputed { get; set; }
    IDSValue MaxBoundsDamping { get; }
    IDSValue MaxBoundsStiffness { get; }
    IDSValue MaxBoundsValue { get; }
    IDSValue MinBoundsDamping { get; }
    IDSValue MinBoundsStiffness { get; }
    IDSValue MinBoundsValue { get; }
    IDSResults Results { get; }
    IDSValue LoadForce { get; }
    IDSValue LoadDamping { get; }
    IDSValue LoadSpringFreePosition { get; }
    IDSValue LoadSpringElasticStiffness { get; }
    IDSValue LoadDryFrictionCoefficient { get; }
    IDSValue LoadDryFrictionRadius { get; }
    DSDOFImposedMotionTypeEnum ImposedMotionType { get; set; }
    IDSValue ImposedMotionValue { get; }
    DSDegreeOfFreedomTypeEnum DegreeOfFreedomType { get; }
}
