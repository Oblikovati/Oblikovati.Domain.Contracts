using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IRigidBodyJoint
{

    IRigidBodyJoints Parent { get; }
    IAssemblyConstraintsEnumerator Constraints { get; }
    IAssemblyJointsEnumerator Joints { get; }
    RigidBodyJointTypeEnum JointType { get; }
    IRigidBodyGroup GroupOne { get; }
    IRigidBodyGroup GroupTwo { get; }
    void GetJointData(out object GeometryOne, out object GeometryTwo, out INameValueMap AdditionalInfo);
}
