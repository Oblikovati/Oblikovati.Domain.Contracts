namespace Oblikovati.Contracts.NotClassified;

public interface IWeldBeads : IList<IWeldBeads>
{
    IWeldBead Item { get; }
}