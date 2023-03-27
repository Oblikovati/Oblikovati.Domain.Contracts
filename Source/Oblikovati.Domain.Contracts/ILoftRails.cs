namespace Oblikovati.Domain.Contracts;

public interface ILoftRails : IList<ILoftRails>
{

    ILoftRail Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
    ILoftRail Add(object Value, object Condition, object Impact);
}
