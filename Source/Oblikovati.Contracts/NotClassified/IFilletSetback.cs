namespace Oblikovati.Contracts.NotClassified;

public interface IFilletSetback
{
    IEdge Edge { get; }
    object Setback { get; set; }
}