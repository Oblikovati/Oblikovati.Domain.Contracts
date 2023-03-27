namespace Oblikovati.Domain.Contracts;

public interface ISketchBlockDefinitions : IList<ISketchBlockDefinitions>
{
    ISketchBlockDefinition Item { get; }

    int Count { get; }
    IEnumerator GetEnumerator();
    ISketchBlockDefinition Add(string Name, object InsertionPoint);
}
