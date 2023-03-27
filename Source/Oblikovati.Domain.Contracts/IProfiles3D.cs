namespace Oblikovati.Domain.Contracts;

public interface IProfiles3D : IList<IProfiles3D>
{

    int Count { get; }
    IProfile3D Item { get; }
    IEnumerator GetEnumerator();
    IProfile3D AddClosed();
    IProfile3D AddOpen();
}
