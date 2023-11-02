namespace Oblikovati.Contracts.NotClassified;

public interface IRigidBodyJoints : IList<IRigidBodyJoints>
{
    IRigidBodyResults Parent { get; }

    IRigidBodyJoint Item { get; }
}