namespace Oblikovati.Domain.Contracts;

public interface IStyles : IList<IStyles>
{

    IStyle Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
}
