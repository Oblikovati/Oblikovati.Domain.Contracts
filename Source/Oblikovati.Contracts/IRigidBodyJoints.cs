namespace Oblikovati.Contracts;

public interface IRigidBodyJoints : IList<IRigidBodyJoints>
{
    IRigidBodyResults Parent { get; }

    IRigidBodyJoint Item { get; }
}