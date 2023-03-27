namespace Oblikovati.Domain.Contracts;

public interface IProfiles : IList<IProfiles>
{

    int Count { get; }
    IProfile Item { get; }
    IEnumerator GetEnumerator();
    IProfile _AddForSolid();
    IProfile AddForSolid(bool Combine, object ProfilePathSegments, object Reserved);
    IProfile _AddForSurface();
    IProfile AddForSurface(object Curve);
}
