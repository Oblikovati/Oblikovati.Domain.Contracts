namespace Oblikovati.Contracts;

public interface IPublications : IList<IPublications>
{
    IPublication Item { get; }

    IPublication Add(string DisplayName);
    IPublication PublishToSVF(string Name);
}