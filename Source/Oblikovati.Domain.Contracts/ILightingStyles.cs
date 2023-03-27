namespace Oblikovati.Domain.Contracts;

public interface ILightingStyles : IList<ILightingStyles>
{


    ILightingStyle Item { get; }
    int Count { get; }
    ILightingStyle Add(string Name);
    IEnumerator GetEnumerator();
}
