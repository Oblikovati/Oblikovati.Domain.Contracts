namespace Oblikovati.Contracts.Sketch2D.Profiles;

public interface IProfiles : IList<IProfiles>
{
    IProfile Item { get; }

    IProfile _AddForSolid();
    IProfile AddForSolid(bool Combine, object ProfilePathSegments, object Reserved);
    IProfile _AddForSurface();
    IProfile AddForSurface(object Curve);
}