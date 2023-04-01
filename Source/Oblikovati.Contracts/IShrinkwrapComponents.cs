namespace Oblikovati.Contracts;

public interface IShrinkwrapComponents : IList<IShrinkwrapComponents>
{
    IShrinkwrapComponent Item { get; }
    IShrinkwrapComponent Add(IShrinkwrapDefinition Definition);

    IShrinkwrapDefinition CreateDefinition(string FullDocumentName);
}