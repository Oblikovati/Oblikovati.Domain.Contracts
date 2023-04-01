namespace Oblikovati.Contracts.Sketch2D.Profiles;

public interface IWires : IList<IWires>
{
    IWire Item { get; }
}