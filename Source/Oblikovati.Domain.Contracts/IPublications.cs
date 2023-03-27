namespace Oblikovati.Domain.Contracts;

public interface IPublications : IList<IPublications>
{

    int Count { get; }
    IPublication Item { get; }
    IEnumerator GetEnumerator();
    IPublication Add(string DisplayName);
    IPublication PublishToSVF(string Name);
}
