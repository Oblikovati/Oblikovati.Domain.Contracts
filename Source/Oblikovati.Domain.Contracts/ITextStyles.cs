namespace Oblikovati.Domain.Contracts;

public interface ITextStyles : IList<ITextStyles>
{

    ITextStyle Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
}
