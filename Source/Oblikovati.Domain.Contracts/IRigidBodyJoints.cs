namespace Oblikovati.Domain.Contracts;

public interface IRigidBodyJoints : IList<IRigidBodyJoints>
{

    IRigidBodyResults Parent { get; }
    int Count { get; }
    IRigidBodyJoint Item { get; }
    IEnumerator GetEnumerator();
}
