namespace Oblikovati.Domain.Contracts;

public interface ITitleBlockDefinitions : IList<ITitleBlockDefinitions>
{

    ITitleBlockDefinition Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
    ITitleBlockDefinition Add(string Name);
}
