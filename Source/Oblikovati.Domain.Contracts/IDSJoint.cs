using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IDSJoint
{

    IDynamicSimulation Parent { get; }
    IDSJointDefinition Definition { get; set; }
    string Name { get; set; }
    bool IsSuppressed { get; set; }
    DSJointTypeEnum JointType { get; }
}
