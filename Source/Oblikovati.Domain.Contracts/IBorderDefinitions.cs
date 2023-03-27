namespace Oblikovati.Domain.Contracts;

public interface IBorderDefinitions : IList<IBorderDefinitions>
{

    IBorderDefinition Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
    IBorderDefinition Add(string Name);
}
