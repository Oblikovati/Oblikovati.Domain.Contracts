namespace Oblikovati.Domain.Contracts;

public interface IDSJoints : IList<IDSJoints>
{

    int Count { get; }
    IDSJoint Item { get; }
    IEnumerator GetEnumerator();
}
