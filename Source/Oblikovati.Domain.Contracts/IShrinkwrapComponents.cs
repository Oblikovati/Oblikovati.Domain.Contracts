namespace Oblikovati.Domain.Contracts;

public interface IShrinkwrapComponents : IList<IShrinkwrapComponents>
{

    int Count { get; }
    IShrinkwrapComponent Item { get; }
    IShrinkwrapComponent Add(IShrinkwrapDefinition Definition);
    IEnumerator GetEnumerator();
    IShrinkwrapDefinition CreateDefinition(string FullDocumentName);
}
