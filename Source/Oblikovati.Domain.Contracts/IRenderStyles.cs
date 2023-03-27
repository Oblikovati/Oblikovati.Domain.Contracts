namespace Oblikovati.Domain.Contracts;

public interface IRenderStyles : IList<IRenderStyles>
{


    IRenderStyle Item { get; }
    int Count { get; }
    IRenderStyle Add(string Name);
    IEnumerator GetEnumerator();
}
