namespace Oblikovati.Domain.Contracts;

public interface IFilletSetbackVertex : IList<IFilletSetbackVertex>
{
    IFilletSetback SetbackItem { get; }
    int SetbackCount { get; }
    IVertex Vertex { get; }
    bool UseSetbacks { get; set; }
    bool MinimalSetback { get; set; }
    IEnumerator GetEnumerator();
}
