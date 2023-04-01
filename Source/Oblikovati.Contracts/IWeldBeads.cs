namespace Oblikovati.Contracts;

public interface IWeldBeads : IList<IWeldBeads>
{
    IWeldBead Item { get; }
}