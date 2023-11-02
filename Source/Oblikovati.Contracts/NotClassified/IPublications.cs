namespace Oblikovati.Contracts.NotClassified;

public interface IPublications : IList<IPublications>
{
    IPublication Item { get; }

    IPublication Add(string DisplayName);
    IPublication PublishToSVF(string Name);
}