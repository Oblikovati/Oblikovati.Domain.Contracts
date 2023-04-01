namespace Oblikovati.Contracts.Sketch3D.Profiles3D;

public interface IProfiles3D : IList<IProfiles3D>
{
    IProfile3D Item { get; }

    IProfile3D AddClosed();
    IProfile3D AddOpen();
}