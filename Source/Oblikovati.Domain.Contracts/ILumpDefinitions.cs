namespace Oblikovati.Domain.Contracts;

public interface ILumpDefinitions : IList<ILumpDefinitions>
{

    ILumpDefinition Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
    ILumpDefinition Add();
}
