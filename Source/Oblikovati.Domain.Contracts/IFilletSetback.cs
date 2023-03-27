namespace Oblikovati.Domain.Contracts;

public interface IFilletSetback
{
    IEdge Edge { get; }
    object Setback { get; set; }
}
