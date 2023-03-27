namespace Oblikovati.Domain.Contracts;

public interface IPartComponentDefinitions : IList<IPartComponentDefinitions>
{
    IPartComponentDefinition Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
}
