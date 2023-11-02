namespace Oblikovati.Contracts.NotClassified;

public interface IVertices : IList<IVertices>
{
    IVertex Item { get; }
}