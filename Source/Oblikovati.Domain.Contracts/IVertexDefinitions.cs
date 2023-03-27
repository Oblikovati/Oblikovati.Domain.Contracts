namespace Oblikovati.Domain.Contracts;

public interface IVertexDefinitions : IList<IVertexDefinitions>
{

    IVertexDefinition Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
    IVertexDefinition Add(IPoint Position);
}
