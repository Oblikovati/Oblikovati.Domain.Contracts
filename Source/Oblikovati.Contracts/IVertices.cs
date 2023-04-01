namespace Oblikovati.Contracts;

public interface IVertices : IList<IVertices>
{
    IVertex Item { get; }
}