namespace Oblikovati.Domain.Contracts;

public interface IRigidBodyGroups : IList<IRigidBodyGroups>
{

    IRigidBodyResults Parent { get; }
    int Count { get; }
    IRigidBodyGroup Item { get; }
    IEnumerator GetEnumerator();
}
