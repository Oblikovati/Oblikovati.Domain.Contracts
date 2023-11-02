namespace Oblikovati.Contracts.NotClassified;

public interface ILoftRails : IList<ILoftRails>
{
    ILoftRail Item { get; }


    ILoftRail Add(object Value, object Condition, object Impact);
}