namespace Oblikovati.Contracts;

public interface ILoftRails : IList<ILoftRails>
{
    ILoftRail Item { get; }


    ILoftRail Add(object Value, object Condition, object Impact);
}