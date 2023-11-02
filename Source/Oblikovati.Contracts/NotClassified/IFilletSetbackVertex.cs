namespace Oblikovati.Contracts.NotClassified;

public interface IFilletSetbackVertex : IList<IFilletSetbackVertex>
{
    IFilletSetback SetbackItem { get; }
    int SetbackCount { get; }
    IVertex Vertex { get; }
    bool UseSetbacks { get; set; }
    bool MinimalSetback { get; set; }
}